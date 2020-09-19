using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbMerchantBill Data Structure.
    /// </summary>
    [Serializable]
    public class HbMerchantBill : AopObject
    {
        /// <summary>
        /// 商家贴息金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 外部订单号，目前交易取不到，先留空
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
