using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceIndustryEnergyCheckResponse.
    /// </summary>
    public class AlipayEcoCityserviceIndustryEnergyCheckResponse : AopResponse
    {
        /// <summary>
        /// 返回场景下的额度检查结果，有额度limited=false，无额度limited=true
        /// </summary>
        [XmlElement("limited")]
        public bool Limited { get; set; }
    }
}
