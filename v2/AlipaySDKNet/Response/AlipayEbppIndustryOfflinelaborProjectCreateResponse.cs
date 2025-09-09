using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborProjectCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryOfflinelaborProjectCreateResponse : AopResponse
    {
        /// <summary>
        /// 登记记录跳转地址
        /// </summary>
        [XmlElement("register_url")]
        public string RegisterUrl { get; set; }
    }
}
