using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamecenterPaymentRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamecenterPaymentRefundModel : AopObject
    {
        /// <summary>
        /// 商户app_id维度下的用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 平台侧订单号，在下单的时候平台返回的trade_no
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
