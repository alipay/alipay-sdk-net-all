using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasPaymentsEvaluateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasPaymentsEvaluateModel : AopObject
    {
        /// <summary>
        /// 影响支付细节的因素，该参数用于定义支付场景
        /// </summary>
        [XmlElement("payment_factor")]
        public PaymentFactor PaymentFactor { get; set; }

        /// <summary>
        /// 需要评估的支付方式
        /// </summary>
        [XmlElement("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
