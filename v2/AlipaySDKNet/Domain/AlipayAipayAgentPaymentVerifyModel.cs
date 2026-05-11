using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayAgentPaymentVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayAgentPaymentVerifyModel : AopObject
    {
        /// <summary>
        /// 客户端会话标识，用于校验买家安全性、真实性
        /// </summary>
        [XmlElement("client_session")]
        public string ClientSession { get; set; }

        /// <summary>
        /// 支付凭证
        /// </summary>
        [XmlElement("payment_proof")]
        public string PaymentProof { get; set; }

        /// <summary>
        /// 支付宝交易号，交易的唯一标识
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
