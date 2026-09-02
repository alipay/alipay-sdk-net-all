using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerPaymentMethod Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerPaymentMethod : AopObject
    {
        /// <summary>
        /// 具体支付方式名称，字段类型与请求参数保持一致
        /// </summary>
        [XmlElement("payment_method_type")]
        public string PaymentMethodType { get; set; }
    }
}
