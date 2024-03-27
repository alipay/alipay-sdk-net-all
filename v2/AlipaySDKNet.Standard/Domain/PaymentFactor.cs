using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentFactor Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentFactor : AopObject
    {
        /// <summary>
        /// 如果将此参数的值指定为true，则在支付过程中向用户显示收银页面; 否则，在支付过程中不会向用户显示收银台页面。
        /// </summary>
        [XmlElement("is_cashier_payment")]
        public bool IsCashierPayment { get; set; }

        /// <summary>
        /// 若该参数指定为true，则支付场景为线下支付；否则，支付场景为线上支付。
        /// </summary>
        [XmlElement("is_in_store_payment")]
        public bool IsInStorePayment { get; set; }
    }
}
