using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarJvordertradeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarJvordertradeSyncModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// JV租车交易所属的订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 交易关联的JV租车主订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// JV租车交易流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// JV租车交易流水对应的交易单号
        /// </summary>
        [XmlElement("out_trade_order_no")]
        public string OutTradeOrderNo { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 交易金额，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 发生交易的小程序appId
        /// </summary>
        [XmlElement("trade_app_id")]
        public string TradeAppId { get; set; }

        /// <summary>
        /// 发生交易的小程序名称
        /// </summary>
        [XmlElement("trade_app_name")]
        public string TradeAppName { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 发生交易的商户pid
        /// </summary>
        [XmlElement("trade_pid")]
        public string TradePid { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易类型,用于区分是支付还是退款
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
