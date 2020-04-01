using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovHealthcodeVerifyModel : AopObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 扫描或查询到的健康码码值
        /// </summary>
        [XmlElement("code_content")]
        public string CodeContent { get; set; }
    }
}
