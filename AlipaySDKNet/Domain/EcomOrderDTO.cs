using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomOrderDTO : AopObject
    {
        /// <summary>
        /// 实际支付金额
        /// </summary>
        [XmlElement("actual_pay_fee")]
        public long ActualPayFee { get; set; }

        /// <summary>
        /// 订单属性标
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("buy_amount")]
        public long BuyAmount { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_fee")]
        public long DiscountFee { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("item_pict_url")]
        public string ItemPictUrl { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("item_price")]
        public long ItemPrice { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 物流单
        /// </summary>
        [XmlElement("logistics_order")]
        public EcomLogisticsOrderDTO LogisticsOrder { get; set; }

        /// <summary>
        /// 主订单id
        /// </summary>
        [XmlElement("main_order_id")]
        public string MainOrderId { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_fee")]
        public long OrderFee { get; set; }

        /// <summary>
        /// 订单id，必填
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单类型：MAIN_AND_DETAIL（主子一体订单）, MAIN（主订单）,DETAIL（子订单）
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 支付单
        /// </summary>
        [XmlElement("pay_order")]
        public PayOrderDTO PayOrder { get; set; }

        /// <summary>
        /// 邮费
        /// </summary>
        [XmlElement("post_fee")]
        public long PostFee { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [XmlElement("trade_end_time")]
        public string TradeEndTime { get; set; }
    }
}
