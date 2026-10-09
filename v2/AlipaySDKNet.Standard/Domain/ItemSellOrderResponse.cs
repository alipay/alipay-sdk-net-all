using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSellOrderResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSellOrderResponse : AopObject
    {
        /// <summary>
        /// cps技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("cps_amount")]
        public string CpsAmount { get; set; }

        /// <summary>
        /// 订单创建时间，格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品唯一编号ID
        /// </summary>
        [XmlElement("item_instance_id")]
        public string ItemInstanceId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商家优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public string MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单的成交场景，表示订单在哪种场景下成交的
        /// </summary>
        [XmlElement("order_scene")]
        public string OrderScene { get; set; }

        /// <summary>
        /// 订单的状态，表示该笔订单目前的一个状态情况。
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付手续费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_commission")]
        public string PayCommission { get; set; }

        /// <summary>
        /// 支付宝优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 预计实收金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_receipt_amount")]
        public string PreReceiptAmount { get; set; }

        /// <summary>
        /// 预计用户实付，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_user_fund_amount")]
        public string PreUserFundAmount { get; set; }

        /// <summary>
        /// 订单预计结算时间，用户支付后确认收货前告知账期的天数， 表述为确认收货后X天结算；用户确认收货后，表述为预计时间格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("predict_settle_time")]
        public string PredictSettleTime { get; set; }

        /// <summary>
        /// 实收金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 退CPS技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_cps_amount")]
        public string RefundCpsAmount { get; set; }

        /// <summary>
        /// 退款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退支付手续费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_pay_commission")]
        public string RefundPayCommission { get; set; }

        /// <summary>
        /// 备注信息，包含如虚拟服务权益卡卡号等信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 结算户号/卡号，如果结算类型为支付宝，展示支付宝账号，如果结算类型为银行卡，展示银行卡号
        /// </summary>
        [XmlElement("settle_account_no")]
        public string SettleAccountNo { get; set; }

        /// <summary>
        /// 结算账户类型，表示结算的账户是银行卡还是支付宝账号
        /// </summary>
        [XmlElement("settle_account_type")]
        public string SettleAccountType { get; set; }

        /// <summary>
        /// 订单结算金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 订单结算时间
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户实付金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("user_fund_amount")]
        public string UserFundAmount { get; set; }
    }
}
