using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Province { get; set; }
        public string City { get; set; }
        public string Barangay { get; set; }
        public string MaritalStatus { get; set; }

        // Custom method to convert UserData to a CSV string
        public string ToCsvString()
        {
            return $"{TransactionNum},{LastName},{GivenName},{MiddleName},{Suffix},{Sex},{BloodType},{Province},{City},{Barangay},{MaritalStatus}";
        }

        // Custom method to parse UserData from a CSV string
        public static ClassInformation FromCsvString(string csv)
        {
            var values = csv.Split(',');
            return new ClassInformation
            {
                TransactionNum = long.Parse(values[0]),
                LastName = values[1],
                GivenName = values[2],
                MiddleName = values[3],
                Suffix = values[4],
                Sex = values[5],
                BloodType = values[6],
                Province = values[7],
                City = values[8],
                Barangay = values[9],
                MaritalStatus = values[10]
            };
        }
    }
}
