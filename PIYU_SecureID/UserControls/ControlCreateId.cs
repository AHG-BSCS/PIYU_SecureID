using System;
using System.Drawing.Imaging;
using AForge.Video.DirectShow;
using Newtonsoft.Json;

namespace PIYU_SecureID
{
    public partial class ControlCreateId : UserControl
    {
        private long transactionNum;
        // Event subsciption handler
        public delegate void btnCreateIDClickedEventHandler();
        public event btnCreateIDClickedEventHandler OnCreateIDClicked;

        public ControlCreateId()
        {
            InitializeComponent();

            GenerateTransactionNum();
            LoadCameraSource();
            LoadProvinces();
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
                    picBoxPicture.Image = Image.FromFile(selectedImagePath);
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
            picBoxPicture.Image = null;
        }

        private void buttonSignature_Click(object sender, EventArgs e)
        {
            if (cmbBoxCameraList.Text != null)
            {
                FormSignature sign = new FormSignature(this);
                sign.ShowDialog();
            }
        }

        private void buttonClearSign_Click(object sender, EventArgs e)
        {
            picBoxSignature.Image = null;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            GenerateTransactionNum();
            txtBoxLastName.Text = "";
            txtBoxFirstName.Text = "";
            txtBoxMiddleName.Text = "";
            txtBoxSuffix.Text = "";
            cmbBoxSex.SelectedIndex = -1;
            cmbBoxBloodType.SelectedIndex = -1;
            cmbBoxMonth.SelectedIndex = -1;
            cmbBoxDay.SelectedIndex = -1;
            cmbBoxYears.SelectedIndex = -1;
            cmbBoxProvince.SelectedIndex = -1;
            cmbBoxBarangay.SelectedIndex = -1;
            cmbBoxCity.SelectedIndex = -1;
            cmbBoxMaritalStatus.SelectedIndex = -1;
            picBoxSignature.Image = null;
            picBoxPicture.Image = null;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxLastName.Text == "" || txtBoxFirstName.Text == "" || cmbBoxSex.SelectedIndex == -1 ||
                cmbBoxBloodType.SelectedIndex == -1 || cmbBoxProvince.SelectedIndex == -1 || cmbBoxBarangay.SelectedIndex == -1 ||
                cmbBoxCity.SelectedIndex == -1 || cmbBoxMaritalStatus.SelectedIndex == -1 || cmbBoxDay.SelectedIndex == -1 ||
                cmbBoxYears.SelectedIndex == -1 || cmbBoxMonth.SelectedIndex == -1 ||
                picBoxSignature.Image == null || picBoxPicture.Image == null)
            {
                MessageBox.Show("Fill All Information.");
            }
            else
            {
                string lastName = txtBoxLastName.Text;
                string givenName = txtBoxFirstName.Text;
                string middleName = txtBoxMiddleName.Text;
                string suffix = txtBoxSuffix.Text;
                string sex = cmbBoxSex.Text;
                string bloodType = cmbBoxBloodType.Text;
                string dateOfBirth = cmbBoxDay.Text + " " + cmbBoxMonth.Text + " " + cmbBoxYears.Text;
                string province = cmbBoxProvince.Text;
                string city = cmbBoxCity.Text;
                string barangay = cmbBoxBarangay.Text;
                string maritalStatus = cmbBoxMaritalStatus.Text;
                byte[] idPhoto = ConvertPictureBoxImageToBase64(picBoxPicture.Image);
                byte[] sign = ConvertPictureBoxImageToBase64(picBoxSignature.Image);
                FormVerificationInfo verify = new FormVerificationInfo(lastName, givenName, middleName, suffix, transactionNum,
                                                                        sex, bloodType, dateOfBirth, province, city, barangay, maritalStatus,
                                                                        idPhoto, sign, this);
                verify.ShowDialog();
                OnCreateIDClicked?.Invoke();
            }
        }

        private void textBoxLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxFirstName.Focus();
                e.Handled = true;
            }
        }

        private void textBoxGivenName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxMiddleName.Focus();
                e.Handled = true;
            }
        }

        private void textBoxMiddleName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxSuffix.Focus();
                e.Handled = true;
            }
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities(cmbBoxProvince.Text.Replace('Ñ', '�'));
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBarangay(cmbBoxProvince.Text.Replace('Ñ', '�'), cmbBoxCity.Text.Replace('Ñ', '�'));
        }

        private void comboBoxSex_DropDownClosed(object sender, EventArgs e)
        {
            lblLastName.Focus();
        }

        private void ControlCreateId_Click(object sender, EventArgs e)
        {
            lblLastName.Focus();
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' ||
                    e.KeyChar == ' ' || e.KeyChar == (char)Keys.Enter)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
        private void GenerateTransactionNum()
        {
            Random random = new Random();

            long randomValue = (long)(random.NextDouble() * (9999999999999L - 1000000000000L) + 1000000000000L);

            this.transactionNum = randomValue;
        }

        private void LoadCameraSource()
        {
            FilterInfoCollection filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filter)
                cmbBoxCameraList.Items.Add(Device.Name);
            cmbBoxCameraList.SelectedIndex = 0;
            VideoCaptureDevice captureDevice = new VideoCaptureDevice();
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
                            cmbBoxProvince.Items.Add(province.Replace('�', 'Ñ'));
                        }
                    }
                }

                cmbBoxProvince.Sorted = true;
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
                cmbBoxCity.Items.Clear();
                cmbBoxBarangay.Items.Clear();

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
                            cmbBoxCity.Items.Add(municipality.Replace('�', 'Ñ'));
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
                cmbBoxBarangay.Items.Clear();

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
                            cmbBoxBarangay.Items.Add(barangay.Replace('�', 'Ñ'));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
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
    }
}
