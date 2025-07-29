using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduOrderPaymentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class EduOrderPaymentDetail : AopObject
    {
        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_way")]
        public string PayWay { get; set; }
    }
}
