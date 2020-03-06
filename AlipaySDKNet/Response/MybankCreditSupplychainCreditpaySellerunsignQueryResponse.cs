using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellerunsignQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellerunsignQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否可解约
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 日志id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 不可解约原因码，解约失败时返回
        /// </summary>
        [XmlElement("unadmit_reason")]
        public string UnadmitReason { get; set; }
    }
}
