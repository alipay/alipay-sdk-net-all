using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AcquireOrder Data Structure.
    /// </summary>
    [Serializable]
    public class AcquireOrder : AopObject
    {
        /// <summary>
        /// 买家外部业务平台会员ID
        /// </summary>
        [XmlElement("buyer_out_member_id")]
        public ReferenceId BuyerOutMemberId { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlArray("goods")]
        [XmlArrayItem("payment_goods")]
        public List<PaymentGoods> Goods { get; set; }

        /// <summary>
        /// 订单金额。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单币种
        /// </summary>
        [XmlElement("order_currency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// 交易超时自动关单时间。
        /// </summary>
        [XmlElement("order_expiry_time")]
        public string OrderExpiryTime { get; set; }

        /// <summary>
        /// 外部业务平台交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 卖家外部业务平台会员ID
        /// </summary>
        [XmlElement("seller_out_member_id")]
        public ReferenceId SellerOutMemberId { get; set; }

        /// <summary>
        /// 物流地址
        /// </summary>
        [XmlElement("shipping")]
        public Shipping Shipping { get; set; }
    }
}
