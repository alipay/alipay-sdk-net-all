using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhoneCardAddressModel Data Structure.
    /// </summary>
    [Serializable]
    public class PhoneCardAddressModel : AopObject
    {
        /// <summary>
        /// 号卡归属地城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 号卡归属省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
