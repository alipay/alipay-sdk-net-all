using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentAddress Data Structure.
    /// </summary>
    [Serializable]
    public class RentAddress : AopObject
    {
        /// <summary>
        /// 所在的城市编码，取值：参考最新的国标编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 所在的详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 所在区县对应的编码，取值：参考最新的国标编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 完整的地址信息，需要包含省市区和详细地址
        /// </summary>
        [XmlElement("full_address")]
        public string FullAddress { get; set; }

        /// <summary>
        /// 所在的省份/直辖市对应的编码，取值：参考最新的国标编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
