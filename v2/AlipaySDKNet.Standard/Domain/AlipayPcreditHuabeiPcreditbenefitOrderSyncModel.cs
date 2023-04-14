using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitOrderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("biz_item_id")]
        public string BizItemId { get; set; }

        /// <summary>
        /// 1640769715
        /// </summary>
        [XmlElement("biz_timestamp")]
        public long BizTimestamp { get; set; }

        /// <summary>
        /// 订单内商品数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create")]
        public string OrderCreate { get; set; }

        /// <summary>
        /// 订单过期时间
        /// </summary>
        [XmlElement("order_expire")]
        public string OrderExpire { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单交易金额（单位：分）
        /// </summary>
        [XmlElement("trade_amount")]
        public long TradeAmount { get; set; }
    }
}
