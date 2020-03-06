using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyerunsignadmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBuyerunsignadmitQueryResponse : AopResponse
    {
        /// <summary>
        /// 能否解约：true/false
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 不可解约原因码，失败时返回
        /// </summary>
        [XmlElement("unadmit_reason")]
        public string UnadmitReason { get; set; }
    }
}
