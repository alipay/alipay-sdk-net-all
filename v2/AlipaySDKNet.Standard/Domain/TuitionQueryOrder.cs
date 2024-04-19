using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionQueryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionQueryOrder : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_payment_id")]
        public string AlipayPaymentId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("isv_payment_id")]
        public string IsvPaymentId { get; set; }
    }
}
