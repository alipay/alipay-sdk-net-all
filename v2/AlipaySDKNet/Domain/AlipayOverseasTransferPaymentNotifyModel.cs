using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferPaymentNotifyModel : AopObject
    {
        /// <summary>
        /// Only used for pass-through. In JSON map format.
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
