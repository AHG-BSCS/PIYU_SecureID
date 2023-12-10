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
            ClassInformation info = new ClassInformation();
            long key = long.Parse(textBoxTransactionNum.Text);

            FillData(info.LoadFromFile("info.txt", key));
        }

        private void FillData(ClassInformation info)
        {
            RefreshData();
            labelLastName.Text += info.LastName;
            labelGivenName.Text += info.GivenName;
            labelMiddleName.Text += info.MiddleName;
            labelSuffix.Text += info.Suffix;
            labelSex.Text += info.Sex;
            labelBloodType.Text += info.BloodType;
            labelDateOfBirth.Text += info.DateOfBirth;
            labelProvince.Text += info.Province;
            labelCity.Text += info.City;
            labelBarangay.Text += info.Barangay;
            labelMaritalStatus.Text += info.MaritalStatus;
            byte[] idPhoto = info.ImageIdPhoto;
            byte[] sign = info.ImageSign;
            if (idPhoto != null)
            {
                using (MemoryStream memoryStream = new MemoryStream(idPhoto, writable: false))
                {
                    Image image = Image.FromStream(memoryStream);

                    pictureBoxIdPhoto.Image = image;
                }
            }
            else
            {
                MessageBox.Show("NoId");
            }
            if (sign != null)
            {
                using (MemoryStream memoryStream = new MemoryStream(sign, writable: false))
                {
                    Image image = Image.FromStream(memoryStream);

                    pictureBoxSign.Image = image;
                }
            }
            else
            {
                MessageBox.Show("NoSign");
            }
        }

        private void RefreshData()
        {
            labelLastName.Text = "Last Name: ";
            labelGivenName.Text = "Given Name: ";
            labelMiddleName.Text = "Middle Name: ";
            labelSuffix.Text = "Suffix: ";
            labelSex.Text = "Sex: ";
            labelBloodType.Text = "Blood Type: ";
            labelDateOfBirth.Text = "Date of Birth: ";
            labelProvince.Text = "Province: ";
            labelCity.Text = "City: ";
            labelBarangay.Text = "Barangay: ";
            labelMaritalStatus.Text = "Marital Status: ";
            pictureBoxIdPhoto.Image = null;
            pictureBoxSign.Image = null;
        }
    }
}
