using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Windows.Compatibility;

namespace PIYU_SecureID
{
    internal class ClassInformation
    {
        public long TransactionNum { get; set; }
        public string LastName { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string Sex { get; set; }
        public string BloodType { get; set; }
        public string DateOfBirth { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Barangay { get; set; }
        public string MaritalStatus { get; set; }
        public byte[] ImageIdPhoto { get; set; }
        public byte[] ImageSign { get; set; }

        public byte[] ImageIdQr { get; set; }
        public string StrIdQr { get; set; }

        public string ToCsvString()
        {
            string imageIdPhotoBase64 = ImageIdPhoto != null ? Convert.ToBase64String(ImageIdPhoto) : string.Empty;
            string imageSignBase64 = ImageSign != null ? Convert.ToBase64String(ImageSign) : string.Empty;

            return $"{TransactionNum}~{LastName}~{GivenName}~{MiddleName}~{Suffix}~{Sex}~{BloodType}~" +
                $"{DateOfBirth}~{Province}~{City}~{Barangay}~{MaritalStatus}~{imageIdPhotoBase64}~{imageSignBase64}";
        }

        public string ToQrIdCsvString()
        {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            using (MemoryStream memoryStream = new MemoryStream(ImageIdQr, writable: false))
            {
                Image image = Image.FromStream(memoryStream);

                pb.Image = image;
            }

            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode((Bitmap)pb.Image);
            string lastResult = "";
            if (result != null && result.ToString() != lastResult)
            {
                return result.ToString();
            }
            return null;
        }

        public static ClassInformation FromCsvString(string csv)
        {
            var values = csv.Split('~');
            return new ClassInformation
            {
                TransactionNum = long.Parse(values[0]),
                LastName = values[1],
                GivenName = values[2],
                MiddleName = values[3],
                Suffix = values[4],
                Sex = values[5],
                BloodType = values[6],
                DateOfBirth = values[7],
                Province = values[8],
                City = values[9],
                Barangay = values[10],
                MaritalStatus = values[11],
                ImageIdPhoto = Convert.FromBase64String(values[12]),
                ImageSign = Convert.FromBase64String(values[13])
            };
        }

        public static ClassInformation FromIdQrCsvString(string csv)
        {
            return new ClassInformation
            {
                StrIdQr = csv
            };
        }

        public ClassInformation LoadFromFile(string filename, long targetKey)
        {
            try
            {
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            ClassInformation userData = ClassInformation.FromCsvString(line);

                            if (userData != null && userData.TransactionNum == targetKey)
                            {
                                return userData;
                            }
                        }
                    }

                    MessageBox.Show($"Record with key {targetKey} not found.");
                }
                else
                {
                    MessageBox.Show($"File not found: {filename}. Creating a new data structure.");
                }

                return new ClassInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
                return new ClassInformation();
            }
        }

        public ClassInformation LoadIdQrFromFile(string filename, string targetKey)
        {
            try
            {
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            ClassInformation userData = ClassInformation.FromIdQrCsvString(line);

                            if (userData != null && userData.StrIdQr == targetKey)
                            {
                                MessageBox.Show("Record found.");
                                return userData;
                            }
                        }
                    }

                    MessageBox.Show("Record not found.");
                }
                else
                {
                    MessageBox.Show($"File not found: {filename}. Creating a new data structure.");
                }

                return new ClassInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
                return new ClassInformation();
            }
        }
    }
}
