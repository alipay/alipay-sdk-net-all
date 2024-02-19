using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemOrderBillDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderBillDetailResponse : AopObject
    {
        /// <summary>
        /// 订单创建时间，格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付宝公域会根据商家的具体成交场景和成交的商品类目来收取一定的技术服务费，技术服务费=结算基数*技术服务费费率，其中费率的部分由商品的类目来计算出。具体详情请查阅：<a href="https://opendocs.alipay.com/b/07w1gp">文档</a>
        /// </summary>
        [XmlElement("fee_categories")]
        public string FeeCategories { get; set; }

        /// <summary>
        /// 订单关联小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单名称
        /// </summary>
        [XmlElement("order_name")]
        public string OrderName { get; set; }

        /// <summary>
        /// 订单总价，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单支付金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 平台技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_service")]
        public string PlatformService { get; set; }

        /// <summary>
        /// 退平台技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_service_refund")]
        public string PlatformServiceRefund { get; set; }

        /// <summary>
        /// 商家前置优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_promotion")]
        public string PrePromotion { get; set; }

        /// <summary>
        /// 订单预计结算时间，用户支付后确认收货前告知账期的天数，  表述为确认收货后X天结算；用户确认收货后，表述为预计时间格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("predict_settle_time")]
        public string PredictSettleTime { get; set; }

        /// <summary>
        /// 订单实收金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 退款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款明细列表
        /// </summary>
        [XmlArray("refund_fee_list")]
        [XmlArrayItem("item_order_bill_refund_response")]
        public List<ItemOrderBillRefundResponse> RefundFeeList { get; set; }

        /// <summary>
        /// 订单二级场景类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 资金结算状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 订单结算数据
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 订单结算金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("settlement_amount")]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
