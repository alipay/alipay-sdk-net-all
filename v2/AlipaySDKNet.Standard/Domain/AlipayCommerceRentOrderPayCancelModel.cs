using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderPayCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderPayCancelModel : AopObject
    {
        /// <summary>
        /// 交易组件业务订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 租金支付外部请求号（跟发起租金支付时传参一致）
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
