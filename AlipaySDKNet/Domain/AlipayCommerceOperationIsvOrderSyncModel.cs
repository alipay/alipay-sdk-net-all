using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIsvOrderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝userid（用户在支付宝平台的2088开头16位id）
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 点餐信息
        /// </summary>
        [XmlElement("catering_order_info")]
        public CateringOrderInfo CateringOrderInfo { get; set; }

        /// <summary>
        /// 外卖配送信息，外卖场景必填
        /// </summary>
        [XmlElement("delivery_info")]
        public CateringDeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 自提：指预计自提结束时间； 外卖：指预计配送结束时间，预计送达开始时间在CateringDeliveryInfo填写
        /// </summary>
        [XmlElement("estimate_end_time")]
        public string EstimateEndTime { get; set; }

        /// <summary>
        /// 预约单必填。 自提：指预计自提开始时间； 外卖：指预计配送开始时间，预计送达开始时间在CateringDeliveryInfo填写
        /// </summary>
        [XmlElement("estimate_start_time")]
        public string EstimateStartTime { get; set; }

        /// <summary>
        /// 商品信息（除排队外必填）
        /// </summary>
        [XmlElement("goods_info")]
        public CateringGoodsInfo GoodsInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单总金额。 自提、外卖、点餐场景下，必填。
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单详情链接
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单扩展字段，示例展示场景：key：scene_type，value：NOTICE_TOUCH；key：cup_type，value:BRING_CUP
        /// </summary>
        [XmlArray("order_extra_info")]
        [XmlArrayItem("extra_info")]
        public List<ExtraInfo> OrderExtraInfo { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modify_time")]
        public string OrderModifyTime { get; set; }

        /// <summary>
        /// 订单类型，枚举支持 ALIPAY_APPLETS：支付宝小程序产生的订单 ALIPAY_POS：收银POS产生的支付宝订单
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 订单类型，枚举支持： RESERVATION：预约单 INSTANT：实时单
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 交易支付金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 自提业务信息，自提场景下必填
        /// </summary>
        [XmlElement("pick_up_info")]
        public PickUpInfo PickUpInfo { get; set; }

        /// <summary>
        /// 排队信息
        /// </summary>
        [XmlElement("queue_info")]
        public QueueInfo QueueInfo { get; set; }

        /// <summary>
        /// 商户订单同步记录id（同一订单，非第一次同步 必填）
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 服务标识
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 订单枚举。参考https://opendocs.alipay.com/pre-open/01vx42
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号（一个订单可能存在多笔支付单，英文逗号隔开）示例：2021031746828992022,2021031746828992034
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}