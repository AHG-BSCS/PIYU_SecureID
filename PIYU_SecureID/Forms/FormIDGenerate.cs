using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator.SwissQrCode;

namespace PIYU_SecureID
{
    public partial class FormIDGenerate : Form
    {
        private Panel panelToPrint;
        private PrintDocument printDocument;
        private int currentPage = 1;
        private long transactionNum;
        private string lastName;
        public string givenName;
        public string middleName;
        public string suffix;
        public string sex;
        public string bloodType;
        public string dateOfBirth;
        public string province;
        public string city;
        public string barangay;
        public string maritalStatus;
        public byte[] idPhoto;
        public byte[] sign;
        public FormIDGenerate(string lastName, string givenName, string middleName, string suffix, long? transactionNum,
                                    string sex, string bloodType, string dateOfBirth, string province, string city, string barangay, string maritalStatus,
                                    byte[] idPhoto)
        {
            this.transactionNum = (long)transactionNum;
            this.lastName = lastName;
            this.givenName = givenName;
            this.middleName = middleName;
            this.suffix = suffix;
            this.sex = sex;
            this.bloodType = bloodType;
            this.dateOfBirth = dateOfBirth;
            this.province = province;
            this.city = city;
            this.barangay = barangay;
            this.maritalStatus = maritalStatus;
            this.idPhoto = idPhoto;
            InitializeComponent();

            picBoxIdPhoto.Image = BytesToImage(idPhoto);

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Margins margins = new Margins(100, 100, 100, 100);
            e.PageSettings.Margins = margins;

            if (currentPage == 1)
            {
                PrintPanel(pnlFrontId, e.Graphics, e.MarginBounds);
                currentPage++;
                e.HasMorePages = true;
            }
            else if (currentPage == 2)
            {
                PrintPanel(pnlBackId, e.Graphics, e.MarginBounds);
                currentPage = 1;
            }
        }

        private void FormIDGenerate_Load(object sender, EventArgs e)
        {
            var pos = lblLastname.Parent.PointToScreen(lblLastname.Location);
            var pos2 = lblGivenName.Parent.PointToScreen(lblGivenName.Location);
            var pos3 = lblMiddleName.Parent.PointToScreen(lblMiddleName.Location);
            var pos4 = lblSuffix.Parent.PointToScreen(lblSuffix.Location);
            var pos5 = lblSex.Parent.PointToScreen(lblSex.Location);
            var pos6 = lblMaritalStatus.Parent.PointToScreen(lblMaritalStatus.Location);
            var pos7 = lblDateOfBirth.Parent.PointToScreen(lblDateOfBirth.Location);
            var pos8 = lblBloodType.Parent.PointToScreen(lblBloodType.Location);
            var pos9 = lblAddress.Parent.PointToScreen(lblAddress.Location);
            var pos10 = lblGenerationDate.Parent.PointToScreen(lblGenerationDate.Location);


            pos = picBoxFrontBackground.PointToClient(pos);
            pos2 = picBoxFrontBackground.PointToClient(pos2);
            pos3 = picBoxFrontBackground.PointToClient(pos3);
            pos4 = picBoxFrontBackground.PointToClient(pos4);
            pos5 = picBoxBackBackground.PointToClient(pos5);
            pos6 = picBoxBackBackground.PointToClient(pos6);
            pos7 = picBoxBackBackground.PointToClient(pos7);
            pos8 = picBoxBackBackground.PointToClient(pos8);
            pos9 = picBoxBackBackground.PointToClient(pos9);
            pos10 = picBoxBackBackground.PointToClient(pos10);

            lblLastname.Parent = picBoxFrontBackground;
            lblLastname.Location = pos;
            lblLastname.BackColor = Color.Transparent;
            lblLastname.Text = lastName;

            lblGivenName.Parent = picBoxFrontBackground;
            lblGivenName.Location = pos2;
            lblGivenName.BackColor = Color.Transparent;
            lblGivenName.Text = givenName;

            lblMiddleName.Parent = picBoxFrontBackground;
            lblMiddleName.Location = pos3;
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.Text = middleName;

            lblSuffix.Parent = picBoxFrontBackground;
            lblSuffix.Location = pos4;
            lblSuffix.BackColor = Color.Transparent;
            lblSuffix.Text = suffix;

            lblSex.Parent = picBoxBackBackground;
            lblSex.Location = pos5;
            lblSex.BackColor = Color.Transparent;
            lblSex.Text = sex;

            lblMaritalStatus.Parent = picBoxBackBackground;
            lblMaritalStatus.Location = pos6;
            lblMaritalStatus.BackColor = Color.Transparent;
            lblMaritalStatus.Text = maritalStatus;

            lblDateOfBirth.Parent = picBoxBackBackground;
            lblDateOfBirth.Location = pos7;
            lblDateOfBirth.BackColor = Color.Transparent;
            lblDateOfBirth.Text = dateOfBirth;

            lblBloodType.Parent = picBoxBackBackground;
            lblBloodType.Location = pos8;
            lblBloodType.BackColor = Color.Transparent;
            lblBloodType.Text = bloodType;

            lblAddress.Parent = picBoxBackBackground;
            lblAddress.Location = pos9;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Text = "Barangay " + barangay + ", " + city + ", " + province;

            lblGenerationDate.Parent = picBoxBackBackground;
            lblGenerationDate.Location = pos10;
            lblGenerationDate.BackColor = Color.Transparent;
            lblGenerationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            LoadQr();
        }

        public static Image BytesToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void LoadQr()
        {
            string idStr = idPhoto != null ? Convert.ToBase64String(idPhoto) : string.Empty;
            MessageBox.Show(idStr);
            string fullData = lastName + "~" + givenName + "~" + middleName + "~" + suffix + "~" + sex + "~"
                + maritalStatus + "~" + bloodType + "~" + dateOfBirth + "~" + province + "~" + city + "~"
                + barangay + "~" + DateTime.Now.ToString("MM/dd/yyyy") + "~" + transactionNum;
            string titan;
            string hash = "}1!v5(eQf5iOYw3I#%;6XtFO=$V5eD6c%v3h}Z('Eev'Xx^S~9";

            byte[] data = UTF8Encoding.UTF8.GetBytes(fullData);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));

                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    titan = Convert.ToBase64String(results, 0, results.Length);
                }
            }

            string dataToEncode = titan;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(dataToEncode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            picBoxQREncrypted.Image = qrCodeImage;
        }

        private void PrintPanel(Panel panel, Graphics graphics, Rectangle bounds)
        {
            Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));

            float scalingFactor = Math.Min(bounds.Width / (float)bitmap.Width, bounds.Height / (float)bitmap.Height);

            graphics.DrawImage(bitmap, bounds, new Rectangle(0, 0, (int)(bitmap.Width * scalingFactor), (int)(bitmap.Height * scalingFactor)), GraphicsUnit.Pixel);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

                ClassInformation data = new ClassInformation();

                data.TransactionNum = transactionNum;

                SaveToFile("Resources/idQr.txt", data);

                this.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ClassInformation data = new ClassInformation();

            data.TransactionNum = transactionNum;

            SaveToFile("Resources/idQr.txt", data);

            this.Close();
        }

        private void SaveToFile(string filename, ClassInformation data)
        {
            try
            {
                string csvString = data.ToQrIdCsvString();
                File.AppendAllText(filename, csvString + Environment.NewLine);
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }
    }
}
