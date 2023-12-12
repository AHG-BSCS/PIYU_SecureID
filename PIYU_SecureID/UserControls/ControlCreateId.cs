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
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace PIYU_SecureID
{
    public partial class ControlCreateId : UserControl
    {
        private long transactionNum;

        public ControlCreateId()
        {
            InitializeComponent();

            FilterInfoCollection filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filter)
                comboBoxCameras.Items.Add(Device.Name);
            comboBoxCameras.SelectedIndex = 0;
            VideoCaptureDevice captureDevice = new VideoCaptureDevice();

            GenerateTransactionNum();
            LoadProvinces();
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
            RefreshData();
        }

        public void RefreshData()
        {
            GenerateTransactionNum();
            textBoxLastName.Text = "";
            textBoxGivenName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxSuffix.Text = "";
            comboBoxSex.SelectedIndex = -1;
            comboBoxBloodType.SelectedIndex = -1;
            comboBoxMonth.SelectedIndex = -1;
            comboBoxDay.SelectedIndex = -1;
            textBoxYear.Text = "";
            comboBoxProvince.SelectedIndex = -1;
            comboBoxBarangay.SelectedIndex = -1;
            comboBoxCity.SelectedIndex = -1;
            comboBoxMaritalStatus.SelectedIndex = -1;
            pictureBoxSignature.Image = null;
            pictureBoxIdPhoto.Image = null;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "" || textBoxGivenName.Text == "" || comboBoxSex.SelectedIndex == -1 ||
                comboBoxBloodType.SelectedIndex == -1 || comboBoxProvince.SelectedIndex == -1 || comboBoxBarangay.SelectedIndex == -1 ||
                comboBoxCity.SelectedIndex == -1 || comboBoxMaritalStatus.SelectedIndex == -1 ||
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
                string sex = comboBoxSex.Text;
                string bloodType = comboBoxBloodType.Text;
                string dateOfBirth = comboBoxDay.Text + " " + comboBoxMonth.Text + " " + textBoxYear.Text;
                string province = comboBoxProvince.Text;
                string city = comboBoxCity.Text;
                string barangay = comboBoxBarangay.Text;
                string maritalStatus = comboBoxMaritalStatus.Text;
                byte[] idPhoto = ConvertPictureBoxImageToBase64(pictureBoxIdPhoto.Image);
                byte[] sign = ConvertPictureBoxImageToBase64(pictureBoxSignature.Image);
                FormVerificationInfo verify = new FormVerificationInfo(lastName, givenName, middleName, suffix, transactionNum,
                                                                        sex, bloodType, dateOfBirth, province, city, barangay, maritalStatus,
                                                                        idPhoto, sign, this);
                verify.ShowDialog();
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

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities(comboBoxProvince.Text);
        }
        private void LoadProvinces()
        {
            try
            {
                string file;
                using (System.IO.StreamReader f = System.IO.File.OpenText("Resources/Address.txt"))
                {
                    file = f.ReadToEnd();
                }

                var regionData = JsonConvert.DeserializeObject<Dictionary<string, RegionInfo>>(file);
                if (regionData != null)
                {
                    foreach (var scenario in regionData.Values)
                    {
                        foreach (var province in scenario.ProvinceList?.Keys ?? Enumerable.Empty<string>())
                        {
                            comboBoxProvince.Items.Add(province);
                        }
                    }
                }

                comboBoxProvince.Sorted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadCities(string selectedProvince)
        {
            try
            {
                comboBoxCity.Items.Clear();
                comboBoxBarangay.Items.Clear();

                string file;
                using (System.IO.StreamReader f = System.IO.File.OpenText("Resources/Address.txt"))
                {
                    file = f.ReadToEnd();
                }

                var regionData = JsonConvert.DeserializeObject<Dictionary<string, RegionInfo>>(file);
                if (regionData != null)
                {
                    foreach (var scenario in regionData.Values)
                    {
                        var selectedProvinceData = scenario.ProvinceList?.GetValueOrDefault(selectedProvince);
                        foreach (var municipality in selectedProvinceData?.MunicipalityList?.Keys ?? Enumerable.Empty<string>())
                        {
                            comboBoxCity.Items.Add(municipality);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadBarangay(string selectedProvince, string selectedCity)
        {
            try
            {
                comboBoxBarangay.Items.Clear();

                string file;
                using (System.IO.StreamReader f = System.IO.File.OpenText("Resources/Address.txt"))
                {
                    file = f.ReadToEnd();
                }

                var regionData = JsonConvert.DeserializeObject<Dictionary<string, RegionInfo>>(file);
                if (regionData != null)
                {
                    foreach (var scenario in regionData.Values)
                    {
                        var selectedProvinceData = scenario.ProvinceList?.GetValueOrDefault(selectedProvince);
                        var selectedCityData = selectedProvinceData?.MunicipalityList?.GetValueOrDefault(selectedCity);
                        foreach (var barangay in selectedCityData?.BarangayList ?? Enumerable.Empty<string>())
                        {
                            comboBoxBarangay.Items.Add(barangay);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBarangay(comboBoxProvince.Text, comboBoxCity.Text);
        }
    }
}
