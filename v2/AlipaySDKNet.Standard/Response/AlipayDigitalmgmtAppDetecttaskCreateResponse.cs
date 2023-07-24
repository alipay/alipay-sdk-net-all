using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtAppDetecttaskCreateResponse.
    /// </summary>
    public class AlipayDigitalmgmtAppDetecttaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 请求幂等校验id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
