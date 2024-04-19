using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentMethod Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentMethod : AopObject
    {
        /// <summary>
        /// 买家支付宝用户ID。 2088开头的16位纯数字。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// customer_id对应的open_id，买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 具体支付方式名称
        /// </summary>
        [XmlElement("payment_method_type")]
        public string PaymentMethodType { get; set; }
    }
}
