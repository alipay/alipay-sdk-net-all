using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentDisburseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferPaymentDisburseModel : AopObject
    {
        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构
        /// </summary>
        [XmlElement("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 批量请求接口，目前仅支持单笔能力
        /// </summary>
        [XmlElement("transactions")]
        public string Transactions { get; set; }
    }
}
