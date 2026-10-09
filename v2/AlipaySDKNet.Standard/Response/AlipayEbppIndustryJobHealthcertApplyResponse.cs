using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobHealthcertApplyResponse.
    /// </summary>
    public class AlipayEbppIndustryJobHealthcertApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝就业健康证认证页面URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
