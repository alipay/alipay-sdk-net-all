using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovHealthcodeQueryModel : AopObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }
    }
}
