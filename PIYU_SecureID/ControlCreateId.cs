﻿using System;
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
using static PIYU_SecureID.ClassCity;

namespace PIYU_SecureID
{
    public partial class ControlCreateId : UserControl
    {
        private long transactionNum;
        private string dateOfBirth;
        private const string LocalApiCityFilePath = "City.txt";
        private const string LocalApiProvinceFilePath = "Province.txt";
        private const string LocalApiBarangayFilePath = "Barangay.txt";
        private Dictionary<string, List<string>> ProvinceAddress = new Dictionary<string, List<string>>();
        private string responseBodyProvince;
        private ClassProvince provinceData;
        private string responseBodyCity;
        private ClassCity cityData;
        private string responseBodyBarangay;
        private ClassBarangay barangayData;
        private string[] idProvinceArr = new string[200];

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
            comboBoxCity.Items.Clear();
            comboBoxBarangay.Items.Clear();
            string selectedProvince = idProvinceArr[comboBoxProvince.SelectedIndex];
            LoadCities(selectedProvince);
        }
        private void LoadProvinces()
        {
            try
            {
                this.responseBodyProvince = File.ReadAllText(LocalApiProvinceFilePath);
                this.provinceData = JsonConvert.DeserializeObject<ClassProvince>(responseBodyProvince);

                foreach (var province in provinceData.data)
                {
                    ProvinceAddress.Add(province.name, new List<string>());
                }
                int i = 0;
                foreach (var id in provinceData.data) 
                {
                    idProvinceArr[i] = id.id.ToString();
                    i++;
                }
                comboBoxProvince.Items.AddRange(ProvinceAddress.Keys.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadCities(string selectedProvinceCode)
        {
            try
            {
                this.responseBodyCity = File.ReadAllText(LocalApiCityFilePath);
                this.cityData = JsonConvert.DeserializeObject<ClassCity>(responseBodyCity);

                foreach (var city in cityData.data)
                {
                    if (selectedProvinceCode == city.province_code)
                    {
                        comboBoxCity.Items.Add(city.name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadBarangay()
        {
            try
            {
                this.responseBodyBarangay = File.ReadAllText(LocalApiBarangayFilePath);
                this.barangayData = JsonConvert.DeserializeObject<ClassBarangay>(responseBodyBarangay);
                this.responseBodyCity = File.ReadAllText(LocalApiCityFilePath);
                this.cityData = JsonConvert.DeserializeObject<ClassCity>(responseBodyCity);
                string cityCode = "";

                foreach (var city in cityData.data)
                {
                    if (comboBoxCity.Text == city.name)
                    {
                        cityCode = city.id.ToString();
                        break;
                    }
                }
                foreach (var barangay in barangayData.data)
                {
                    if (cityCode == barangay.city_code)
                    {
                        comboBoxBarangay.Items.Add(barangay.name);
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
            comboBoxBarangay.Items.Clear();
            LoadBarangay();
        }
    }
}
