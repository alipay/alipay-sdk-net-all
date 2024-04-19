using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayerDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class PayerDetailVO : AopObject
    {
        /// <summary>
        /// 付款账户，pay_mode为OFFLINE时可选
        /// </summary>
        [XmlElement("account")]
        public AccountDTO Account { get; set; }

        /// <summary>
        /// 支付模式，包括网银推单，线下转账，票据支付等；根据平台协议约定平台支持的支付模式
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("payer_amount")]
        public string PayerAmount { get; set; }

        /// <summary>
        /// 付款币种
        /// </summary>
        [XmlElement("payer_currency")]
        public string PayerCurrency { get; set; }
    }
}
