using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIYU_SecureID
{
    public partial class ControlCheckId : UserControl
    {
        public ControlCheckId()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClassInformation info = new ClassInformation();
                long key = long.Parse(textBoxTransactionNum.Text);

                FillData(info.LoadFromFile("info.txt", key));
            }
            catch
            {
                MessageBox.Show("Invalid transaction number.");
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
            }
            catch
            {
                
            }
        }

        private void RefreshData()
        {
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
