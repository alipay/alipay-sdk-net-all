using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobPayslipInitializeResponse.
    /// </summary>
    public class AlipayEbppIndustryJobPayslipInitializeResponse : AopResponse
    {
        /// <summary>
        /// 开通收款账号跳转地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
