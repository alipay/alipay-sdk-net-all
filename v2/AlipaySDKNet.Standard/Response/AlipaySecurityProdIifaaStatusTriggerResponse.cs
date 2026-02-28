using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIifaaStatusTriggerResponse.
    /// </summary>
    public class AlipaySecurityProdIifaaStatusTriggerResponse : AopResponse
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
