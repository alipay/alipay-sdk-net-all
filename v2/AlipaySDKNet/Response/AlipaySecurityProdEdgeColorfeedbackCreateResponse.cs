using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdEdgeColorfeedbackCreateResponse.
    /// </summary>
    public class AlipaySecurityProdEdgeColorfeedbackCreateResponse : AopResponse
    {
        /// <summary>
        /// 反馈生成的跟踪字符串，用于后续业务问题排查
        /// </summary>
        [XmlElement("trace")]
        public string Trace { get; set; }
    }
}
