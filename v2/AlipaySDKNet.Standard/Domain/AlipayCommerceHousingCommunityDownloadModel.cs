using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingCommunityDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingCommunityDownloadModel : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }
    }
}
