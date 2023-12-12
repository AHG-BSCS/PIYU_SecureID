using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PIYU_SecureID
{
    public class RegionInfo
    {
        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("province_list")]
        public Dictionary<string, ProvinceInfo> ProvinceList { get; set; }
    }

    public class ProvinceInfo
    {
        [JsonProperty("municipality_list")]
        public Dictionary<string, MunicipalityInfo> MunicipalityList { get; set; }
    }

    public class MunicipalityInfo
    {
        [JsonProperty("barangay_list")]
        public List<string> BarangayList { get; set; }
    }
}
