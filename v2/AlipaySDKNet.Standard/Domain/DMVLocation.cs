using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DMVLocation Data Structure.
    /// </summary>
    [Serializable]
    public class DMVLocation : AopObject
    {
        /// <summary>
        /// 所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 所在城市国标码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 所在区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 所在区国标码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 所在省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 所在省国标码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
