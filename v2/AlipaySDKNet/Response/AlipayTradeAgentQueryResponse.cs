using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeAgentQueryResponse.
    /// </summary>
    public class AlipayTradeAgentQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧智能体唯一ID。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 本次申请的操作类型。
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 千问平台侧外部请求号。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 审核拒绝原因。
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 当前申请状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
