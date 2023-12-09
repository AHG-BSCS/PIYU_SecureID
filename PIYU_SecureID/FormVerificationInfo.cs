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
        public FormVerificationInfo(string lastName, string givenName, string middleName, string suffix, long transactionNum)
        {
            InitializeComponent();

            this.transactionNum = transactionNum;
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
            this.Close();
        }
    }
}
