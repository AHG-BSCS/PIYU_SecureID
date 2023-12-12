using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;

namespace PIYU_SecureID
{
    public partial class ControlVerifyId : UserControl
    {
        private long? key;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private ClassInformation info = new ClassInformation();
        private string lastDecodedResult = "";

        public ControlVerifyId()
        {
            InitializeComponent();

            FilterInfoCollection filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filter)
                comboBoxCameras.Items.Add(Device.Name);
            comboBoxCameras.SelectedIndex = 0;
            VideoCaptureDevice captureDevice = new VideoCaptureDevice();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (buttonStartStop.Text == "START")
            {
                InitializeWebCam();
                timer1.Start();
                buttonStartStop.Text = "STOP";
            }
            else
            {
                timer1.Stop();
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBoxQrScanner.Image = null;
                buttonStartStop.Text = "START";
            }
        }

        private void InitializeWebCam()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                if (comboBoxCameras.SelectedItem != null)
                {
                    int selectedCameraIndex = comboBoxCameras.SelectedIndex;
                    videoSource = new VideoCaptureDevice(videoDevices[selectedCameraIndex].MonikerString);
                    videoSource.NewFrame += VideoSource_NewFrame;
                    videoSource.Start();
                }
                else
                {
                    MessageBox.Show("Please select a camera from the list.");
                }
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap originalFrame = (Bitmap)eventArgs.Frame.Clone();

            int size = Math.Min(originalFrame.Width, originalFrame.Height);
            Rectangle cropArea = new Rectangle((originalFrame.Width - size) / 2, (originalFrame.Height - size) / 2, size, size);
            Bitmap squareFrame = originalFrame.Clone(cropArea, originalFrame.PixelFormat);

            pictureBoxQrScanner.Image = squareFrame;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxQrScanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBoxQrScanner.Image);
                if (result != null)
                {
                    string decodedResult = result.ToString();

                    if (decodedResult != lastDecodedResult)
                    {
                        lastDecodedResult = decodedResult;
                        HandleResult(decodedResult);
                    }
                }
            }
        }

        private void HandleResult(string qrData)
        {
            try
            {
                string hash = "}1!v5(eQf5iOYw3I#%;6XtFO=$V5eD6c%v3h}Z('Eev'Xx^S~9"; // Replace with your secret key
                byte[] data = Convert.FromBase64String(qrData);

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                    {
                        Key = keys,
                        Mode = CipherMode.ECB,
                        Padding = PaddingMode.PKCS7
                    })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                        string decryptedData = Encoding.UTF8.GetString(results);
                        UpdateLabels(decryptedData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error decoding QR code: {ex.Message}");
            }
        }

        private void UpdateLabels(string decryptedData)
        {
            string[] pieces = decryptedData.Split('~');

            try
            {
                labelLastName.Text = pieces[0];
                labelGivenName.Text = pieces[1];
                labelMiddleName.Text = pieces[2];
                labelSuffix.Text = pieces[3];
                labelSex.Text = pieces[4];
                labelMaritalStatus.Text = pieces[5];
                labelBloodType.Text = pieces[6];
                labelDateOfBirth.Text = pieces[7];
                labelProvince.Text = pieces[8];
                labelCity.Text = pieces[9];
                labelBarangay.Text = pieces[10];
                labelDateIssued.Text = pieces[11];
                //string idStr = pieces[12];
                //byte[] idByte = Convert.FromBase64String(idStr);
                //pictureBoxIdPhoto.Image = BytesToImage(idByte);
            }
            catch
            {
                MessageBox.Show("Invalid QR code data format.");
            }
        }
        

        public static Image BytesToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void ControlVerifyId_Leave(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            buttonStartStop.Text = "START";
            pictureBoxQrScanner.Image = null;
            RefreshData();
        }

        private void textBoxTransactionNum_TextChanged(object sender, EventArgs e)
        {
            string key = textBoxTransactionNum.Text;

            info = info.LoadIdQrFromFile("Resources/idQr.txt", key);
            info = info.LoadFromFile("Resources/info.txt", info.TransactionNum);
            FillData(info);
        }

        private void FillData(ClassInformation info)
        {
            try
            {
                RefreshData();
                labelLastName.Text = info.LastName;
                labelGivenName.Text = info.GivenName;
                labelMiddleName.Text = info.MiddleName;
                labelSuffix.Text = info.Suffix;
                labelSex.Text = info.Sex;
                labelBloodType.Text = info.BloodType;
                labelDateOfBirth.Text = info.DateOfBirth;
                labelProvince.Text = info.Province;
                labelCity.Text = info.City;
                labelBarangay.Text = info.Barangay;
                labelMaritalStatus.Text = info.MaritalStatus;
                byte[] idPhoto = info.ImageIdPhoto;
                byte[] sign = info.ImageSign;
                using (MemoryStream memoryStream = new MemoryStream(idPhoto, writable: false))
                {
                    Image image = Image.FromStream(memoryStream);

                    pictureBoxIdPhoto.Image = image;
                }
                using (MemoryStream memoryStream = new MemoryStream(sign, writable: false))
                {
                    Image image = Image.FromStream(memoryStream);

                    pictureBoxSign.Image = image;
                }
            }
            catch
            {
                // Handle exceptions
            }
        }

        private void RefreshData()
        {
            this.key = null;
            labelLastName.Text = "";
            labelGivenName.Text = "";
            labelMiddleName.Text = "";
            labelSuffix.Text = "";
            labelSex.Text = "";
            labelBloodType.Text = "";
            labelDateOfBirth.Text = "";
            labelProvince.Text = "";
            labelCity.Text = "";
            labelBarangay.Text = "";
            labelMaritalStatus.Text = "";
            pictureBoxIdPhoto.Image = null;
            pictureBoxSign.Image = null;
        }
    }
}
