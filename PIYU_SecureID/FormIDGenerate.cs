using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public PictureBox idPhoto;
        public ControlCreateId createId;
        public FormIDGenerate(string lastName, string givenName, string middleName, string suffix, long transactionNum,
                                    string sex, string bloodType, string dateOfBirth, string province, string city, string barangay, string maritalStatus,
                                    PictureBox idPhoto)
        {
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
            InitializeComponent();
        }

        private void FormIDGenerate_Load(object sender, EventArgs e)
        {
            var pos = label3.Parent.PointToScreen(label3.Location);
            var pos2 = label4.Parent.PointToScreen(label4.Location);
            var pos3 = label5.Parent.PointToScreen(label5.Location);
            var pos4 = label6.Parent.PointToScreen(label6.Location);
            var pos5 = label7.Parent.PointToScreen(label7.Location);
            var pos6 = label8.Parent.PointToScreen(label8.Location);
            var pos7 = label9.Parent.PointToScreen(label9.Location);
            var pos8 = label10.Parent.PointToScreen(label10.Location);
            var pos9 = label11.Parent.PointToScreen(label11.Location);
            var pos10 = label12.Parent.PointToScreen(label12.Location);


            pos = pictureBox1.PointToClient(pos);
            pos2 = pictureBox1.PointToClient(pos2);
            pos3 = pictureBox1.PointToClient(pos3);
            pos4 = pictureBox1.PointToClient(pos4);
            pos5 = pictureBox2.PointToClient(pos5);
            pos6 = pictureBox2.PointToClient(pos6);
            pos7 = pictureBox2.PointToClient(pos7);
            pos8 = pictureBox2.PointToClient(pos8);
            pos9 = pictureBox2.PointToClient(pos9);
            pos10 = pictureBox2.PointToClient(pos10);

            label3.Parent = pictureBox1;
            label3.Location = pos;
            label3.BackColor = Color.Transparent;
            label3.Text = lastName;

            label4.Parent = pictureBox1;
            label4.Location = pos2;
            label4.BackColor = Color.Transparent;
            label4.Text = givenName;

            label5.Parent = pictureBox1;
            label5.Location = pos3;
            label5.BackColor = Color.Transparent;
            label5.Text = middleName;

            label6.Parent = pictureBox1;
            label6.Location = pos4;
            label6.BackColor = Color.Transparent;
            label6.Text = suffix;

            label7.Parent = pictureBox2;
            label7.Location = pos5;
            label7.BackColor = Color.Transparent;
            label7.Text = sex;
            
            label8.Parent = pictureBox2;
            label8.Location = pos6;
            label8.BackColor = Color.Transparent;
            label8.Text = maritalStatus;

            label9.Parent = pictureBox2;
            label9.Location = pos7;
            label9.BackColor = Color.Transparent;
            label9.Text = dateOfBirth;

            label10.Parent = pictureBox2;
            label10.Location = pos8;
            label10.BackColor = Color.Transparent;
            label10.Text = bloodType;

            label11.Parent = pictureBox2;
            label11.Location = pos9;
            label11.BackColor = Color.Transparent;
            label11.Text = "TEST";
            
            label12.Parent = pictureBox2;
            label12.Location = pos10;
            label12.BackColor = Color.Transparent;
            label12.Text = DateTime.Now.ToString("dd/MM/yyyy");

            pictureBoxIdPhoto.Image = idPhoto.Image;

            string fullData = lastName + "/" + givenName + "/" + middleName + "/" + suffix + "/" + sex + "/" + maritalStatus + "/" + bloodType + "/" + DateTime.Now.ToString("MM/dd/yyyy");
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

            string dataToEncode = titan ;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(dataToEncode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pictureBoxQREncrypted.Image = qrCodeImage;
        }
    }
}
