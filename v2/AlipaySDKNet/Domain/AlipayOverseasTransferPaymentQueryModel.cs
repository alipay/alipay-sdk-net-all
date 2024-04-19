using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferPaymentQueryModel : AopObject
    {
        /// <summary>
        /// 透出字段。以map方式存储
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 源机构编号
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// AC交易流水号
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
