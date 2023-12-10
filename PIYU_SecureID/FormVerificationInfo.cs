using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public string province;
        public string city;
        public string barangay;
        public string maritalStatus;
        public ControlCreateId createId;
        public FormVerificationInfo(string lastName, string givenName, string middleName, string suffix, long transactionNum,
                                    string sex, string bloodType, string province, string city, string barangay, string maritalStatus,
                                    ControlCreateId createId)
        {
            InitializeComponent();

            this.transactionNum = transactionNum;
            this.lastName = lastName;
            this.givenName = givenName;
            this.middleName = middleName;
            this.suffix = suffix;
            this.sex = sex;
            this.bloodType = bloodType;
            this.province = province;
            this.city = city;
            this.barangay = barangay;
            this.maritalStatus = maritalStatus;
            this.createId = createId;

            GenerateAndDisplayQRCode();

            labelName.Text += givenName + " " + middleName + " " + lastName + " " + suffix;
            labelTransactionNum.Text += transactionNum.ToString();

            panelToPrint = panelMain;

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

            pictureBoxQRCode.Image = qrCodeImage;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            data.Province = province;
            data.City = city;
            data.Barangay = barangay;
            data.MaritalStatus = maritalStatus;

            SaveToFile("info.txt", data);

            createId.RefreshData();
            this.Close();
        }

        private void SaveToFile(string filename, ClassInformation data)
        {
            try
            {
                string csvString = data.ToCsvString();
                File.WriteAllText(filename, csvString);
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
