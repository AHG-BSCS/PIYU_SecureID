using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;

namespace PIYU_SecureID
{
    public partial class ControlCheckId : UserControl
    {
        private long? key;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public delegate void btnCheckIDClickedEventHandler();
        public event btnCheckIDClickedEventHandler OnCheckIDClicked;
        public ControlCheckId()
        {
            InitializeComponent();

            UpdateCameraSelection();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (pictureBoxIdPhoto.Image != null)
            {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                }
                if (videoSource != null)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
                pictureBoxQrScanner.Image = null;
                buttonStartStop.Text = "START";

                long? transactionNum = key;
                string lastName = labelLastName.Text;
                string givenName = labelGivenName.Text;
                string middleName = labelMiddleName.Text;
                string suffix = labelSuffix.Text;
                string sex = labelSex.Text;
                string bloodType = labelBloodType.Text;
                string dateOfBirth = labelDateOfBirth.Text;
                string province = labelProvince.Text;
                string city = labelCity.Text;
                string barangay = labelBarangay.Text;
                string maritalStatus = labelMaritalStatus.Text;
                FormIDGenerate generate = new FormIDGenerate(lastName, givenName, middleName, suffix, transactionNum,
                                                            sex, bloodType, dateOfBirth, province, city, barangay, maritalStatus,
                                                            ConvertPictureBoxImageToBase64(pictureBoxIdPhoto.Image));
                generate.ShowDialog();
                OnCheckIDClicked?.Invoke();
            }
        }

        private byte[] ConvertPictureBoxImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
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
                panelInfo.Visible = true;
            }
            catch
            {

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
            panelInfo.Visible = false;
        }

        private void textBoxTransactionNum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTransactionNum.TextLength == 13)
            {
                try
                {
                    ClassInformation info = new ClassInformation();
                    long key = long.Parse(textBoxTransactionNum.Text);

                    FillData(info.LoadFromFile("Resources/info.txt", key));
                    this.key = key;
                }
                catch
                {
                    MessageBox.Show("Invalid transaction number.");
                    RefreshData();
                }
            }
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (buttonStartStop.Text == "CAMERA")
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
                buttonStartStop.Text = "CAMERA";
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

        private void ControlCheckId_Leave(object sender, EventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            buttonStartStop.Text = "START";
            pictureBoxQrScanner.Image = null;
            textBoxTransactionNum.Text = "";
            RefreshData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxQrScanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBoxQrScanner.Image);
                string lastResult = "";
                if (result != null && result.ToString() != lastResult)
                {
                    textBoxTransactionNum.Text = result.ToString();
                }
            }
        }
        private void UpdateCameraSelection()
        {
            FilterInfoCollection filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filter)
                comboBoxCameras.Items.Add(Device.Name);
            comboBoxCameras.SelectedIndex = 0;
            VideoCaptureDevice captureDevice = new VideoCaptureDevice();
        }
    }
}
