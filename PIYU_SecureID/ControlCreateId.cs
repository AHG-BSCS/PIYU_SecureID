using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Claims;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIYU_SecureID
{
    public partial class ControlCreateId : UserControl
    {
        private long transactionNum;
        public ControlCreateId()
        {
            InitializeComponent();

            dateTimePickerBirthday.Text = null;

            FilterInfoCollection filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filter)
                comboBoxCameras.Items.Add(Device.Name);
            comboBoxCameras.SelectedIndex = 0;
            VideoCaptureDevice captureDevice = new VideoCaptureDevice();

            GenerateTransactionNum();
        }

        private void GenerateTransactionNum()
        {
            Random random = new Random();

            long randomValue = (long)(random.NextDouble() * (9999999999999L - 1000000000000L) + 1000000000000L);

            this.transactionNum = randomValue;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    pictureBoxIdPhoto.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void buttonCamera_Click(object sender, EventArgs e)
        {
            FormCamera cam = new FormCamera(this);
            cam.ShowDialog();
        }

        private void buttonClearPhoto_Click(object sender, EventArgs e)
        {
            pictureBoxIdPhoto.Image = null;
        }

        private void buttonSignature_Click(object sender, EventArgs e)
        {
            if (comboBoxCameras.Text != null)
            {
                FormSignature sign = new FormSignature(this);
                sign.ShowDialog();
            }
        }

        private void buttonClearSign_Click(object sender, EventArgs e)
        {
            pictureBoxSignature.Image = null;
        }

        private void comboBoxCameras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxCameras_TextChanged(object sender, EventArgs e)
        {
            pictureBoxIdPhoto.Image = null;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxLastName.Text = "";
            textBoxGivenName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxSuffix.Text = "";
            comboBoxSex.SelectedIndex = -1;
            comboBoxBloodType.SelectedIndex = -1;
            comboBoxProvince.SelectedIndex = -1;
            comboBoxBarangay.SelectedIndex = -1;
            comboBoxCity.SelectedIndex = -1;
            comboBoxMaritalStatus.SelectedIndex = -1;
            dateTimePickerBirthday.Text = null;
            pictureBoxSignature.Image = null;
            pictureBoxIdPhoto.Image = null;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "" || textBoxGivenName.Text == "" || textBoxMiddleName.Text == "" ||comboBoxSex.SelectedIndex == -1 ||
                comboBoxBloodType.SelectedIndex == -1 || comboBoxProvince.SelectedIndex == -1 || //comboBoxBarangay.SelectedIndex == -1 ||
                //comboBoxCity.SelectedIndex == -1 || comboBoxMaritalStatus.SelectedIndex == -1 || dateTimePickerBirthday.Text == null ||
                pictureBoxSignature.Image == null || pictureBoxIdPhoto.Image == null)
            {
                MessageBox.Show("Fill All Information.");
            }
            else
            {
                string lastName = textBoxLastName.Text;
                string givenName = textBoxGivenName.Text;
                string middleName = textBoxMiddleName.Text;
                string suffix = textBoxSuffix.Text;
                FormVerificationInfo verify = new FormVerificationInfo(lastName, givenName, middleName, suffix, transactionNum);
                verify.ShowDialog();
            }
        }

        private void textBoxLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxGivenName.Focus();
                e.Handled = true;
            }
        }

        private void textBoxGivenName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxMiddleName.Focus();
                e.Handled = true;
            }
        }

        private void textBoxMiddleName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxSuffix.Focus();
                e.Handled = true;
            }
        }
    }
}
