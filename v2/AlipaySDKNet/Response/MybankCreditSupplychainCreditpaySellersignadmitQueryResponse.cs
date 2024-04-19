using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellersignadmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellersignadmitQueryResponse : AopResponse
    {
        /// <summary>
        /// 准入/不准入:true/false
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 签约不准入原因
        /// </summary>
        [XmlElement("unadmit_reason")]
        public string UnadmitReason { get; set; }
    }
}
