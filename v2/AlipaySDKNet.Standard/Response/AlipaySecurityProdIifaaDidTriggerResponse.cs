using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIifaaDidTriggerResponse.
    /// </summary>
    public class AlipaySecurityProdIifaaDidTriggerResponse : AopResponse
    {
        /// <summary>
        /// 数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
