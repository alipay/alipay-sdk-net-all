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
        /// 在门店消费用户的标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

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
        /// 商品队列。订单积压场景中，该订单前方还有多少商品待处理，如喜茶点单，前方还有99杯。选填、数值、精确到整数。
        /// </summary>
        [XmlElement("goods_queue_num")]
        public long GoodsQueueNum { get; set; }

        /// <summary>
        /// 开发票的跳转链接，用户点击可进入该笔订单开发票的页面（商户开票不一定和支付宝发票管家打通，而是商户小程序内的页面或三方开票的H5页面）。生成后订单生命周期内不可变更
        /// </summary>
        [XmlElement("invoice_url")]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// 环保标签，支持多标签，英文逗号隔开，目前支持标签：N_PACKAGED：不打包 N_STRAW：不要吸管 N_DISPOSABLE_CUP：环保杯（用非一次性杯子如自带杯或用商户提供的马克杯）
        /// </summary>
        [XmlElement("low_carbon_behavior")]
        public string LowCarbonBehavior { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单总金额。 自提、外卖、点餐（GENERAL蜻蜓点餐）场景下，必填。
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单详情链接，GENERAL蜻蜓点餐可选填，其他业务场景必填
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
        /// 订单队列。订单积压场景中，该订单前方还有多少订单待处理，如喜茶点单，前方还有60单。选填、数值、精确到整数。
        /// </summary>
        [XmlElement("order_queue_num")]
        public long OrderQueueNum { get; set; }

        /// <summary>
        /// 订单类型，枚举支持 ALIPAY_APPLETS：支付宝小程序产生的订单 ALIPAY_POS：收银POS产生的支付宝订单 MERCHANT_APP：APP交易产生的支付宝订单 OTHERS：其他渠道的支付宝交易 KIOSKS：自助设备（蜻蜓点餐填此类型）
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
        /// 返佣pid，GENERAL蜻蜓点餐业务场景，必填
        /// </summary>
        [XmlElement("rebate_pid")]
        public string RebatePid { get; set; }

        /// <summary>
        /// 订单同步接口返回record_id（同一订单，非第一次同步 必填）
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 开发票跳转链接，用户点击可进入商家小程序直接将上次购物的商品加入购物车。生成后订单生命周期内不可变更
        /// </summary>
        [XmlElement("reorder_url")]
        public string ReorderUrl { get; set; }

        /// <summary>
        /// 服务标识（区分服务类型如  自提/外卖）
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 订单对应的服务相关信息
        /// </summary>
        [XmlElement("service_info")]
        public CateringServiceInfo ServiceInfo { get; set; }

        /// <summary>
        /// 订单枚举。请参考产品文档场景说明。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号，除CREATE、CLOSED节点必填，不支持多个交易号。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
