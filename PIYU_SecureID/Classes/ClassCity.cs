using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIYU_SecureID
{
    public class ClassCity
    {
        public class Pagination
        {
            public int total { get; set; }
            public int perPage { get; set; }
            public int page { get; set; }
            public int lastPage { get; set; }
        }

        public class City
        {
            public string id { get; set; }
            public string name { get; set; }
            public string province_code { get; set; }
            public string href { get; set; }
        }

        public Pagination pagination { get; set; }
        public List<City> data { get; set; }
    }

}
