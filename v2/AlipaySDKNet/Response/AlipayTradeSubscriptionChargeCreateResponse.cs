using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionChargeCreateResponse.
    /// </summary>
    public class AlipayTradeSubscriptionChargeCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付链接
        /// </summary>
        [XmlElement("cashier_url")]
        public string CashierUrl { get; set; }

        /// <summary>
        /// 续费模式
        /// </summary>
        [XmlElement("charge_mode")]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 当前账单截止时间
        /// </summary>
        [XmlElement("current_period_end")]
        public string CurrentPeriodEnd { get; set; }

        /// <summary>
        /// 当前账单开始时间
        /// </summary>
        [XmlElement("current_period_start")]
        public string CurrentPeriodStart { get; set; }

        /// <summary>
        /// 订阅项id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付单ID
        /// </summary>
        [XmlElement("payment_order_id")]
        public string PaymentOrderId { get; set; }

        /// <summary>
        /// 支付单对应的账单截止时间
        /// </summary>
        [XmlElement("payment_period_end")]
        public string PaymentPeriodEnd { get; set; }

        /// <summary>
        /// 支付单对应的账单开始时间
        /// </summary>
        [XmlElement("payment_period_start")]
        public string PaymentPeriodStart { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
