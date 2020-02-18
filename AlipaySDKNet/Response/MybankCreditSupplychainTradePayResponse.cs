using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainTradePayResponse.
    /// </summary>
    public class MybankCreditSupplychainTradePayResponse : AopResponse
    {
        /// <summary>
        /// 业务事件受理的流水号，建议调用方保持此流水号，以方便后续业务处理
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
