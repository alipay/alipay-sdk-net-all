using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayAgentFulfillmentConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayAgentFulfillmentConfirmModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
