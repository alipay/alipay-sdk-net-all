using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalCityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalCityDTO : AopObject
    {
        /// <summary>
        /// 城市行政编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }
    }
}
