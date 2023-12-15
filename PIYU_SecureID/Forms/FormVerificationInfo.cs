using System;
using System.Drawing.Printing;
using PIYU_SecureID.Classes;
using QRCoder;

namespace PIYU_SecureID
{
    public partial class FormVerificationInfo : Form
    {
        private Panel panelToPrint;
        private PrintDocument printDocument;
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
        public ControlCreateId createId;

        public FormVerificationInfo(string lastName, string givenName, string middleName, string suffix, long transactionNum,
                                    string sex, string bloodType, string dateOfBirth, string province, string city, string barangay, string maritalStatus,
                                    byte[] idPhoto, byte[] sign, ControlCreateId createId)
        {
            InitializeComponent();
            DesignHelper.PaintRoundBorder(this);

            this.transactionNum = transactionNum;
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
            this.sign = sign;
            this.createId = createId;

            GenerateAndDisplayQRCode();

            lblName.Text += givenName + " " + middleName + " " + lastName + " " + suffix;
            lblTransactionNumber.Text += transactionNum.ToString();

            panelToPrint = pnlTransactionSlip;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
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
                data.LastName = lastName;
                data.GivenName = givenName;
                data.MiddleName = middleName;
                data.Suffix = suffix;
                data.Sex = sex;
                data.BloodType = bloodType;
                data.DateOfBirth = dateOfBirth;
                data.Province = province;
                data.City = city;
                data.Barangay = barangay;
                data.MaritalStatus = maritalStatus;
                data.ImageIdPhoto = idPhoto;
                data.ImageSign = sign;

                SaveToFile("Resources/info.txt", data);

                createId.RefreshData();
                this.Close();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bitmap, e.MarginBounds);
            e.HasMorePages = false;

            bitmap.Dispose();
        }

        private void GenerateAndDisplayQRCode()
        {
            string dataToEncode = this.transactionNum.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(dataToEncode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            picBoxQRCode.Image = qrCodeImage;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ClassInformation data = new ClassInformation();
            data.TransactionNum = transactionNum;
            data.LastName = lastName;
            data.GivenName = givenName;
            data.MiddleName = middleName;
            data.Suffix = suffix;
            data.Sex = sex;
            data.BloodType = bloodType;
            data.DateOfBirth = dateOfBirth;
            data.Province = province;
            data.City = city;
            data.Barangay = barangay;
            data.MaritalStatus = maritalStatus;
            data.ImageIdPhoto = idPhoto;
            data.ImageSign = sign;

            SaveToFile("Resources/info.txt", data);

            createId.RefreshData();
            this.Close();
        }

        private void SaveToFile(string filename, ClassInformation data)
        {
            try
            {
                string csvString = data.ToCsvString();
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

        private void buttonCopyTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(transactionNum.ToString());

            MessageBox.Show("Transaction Number copied to clipboard!");
        }
    }
}
