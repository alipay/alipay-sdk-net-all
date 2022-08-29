using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAggrepayOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAggrepayOrderCreateModel : AopObject
    {
        /// <summary>
        /// 微信用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
