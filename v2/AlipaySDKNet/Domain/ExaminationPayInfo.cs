using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationPayInfo : AopObject
    {
        /// <summary>
        /// 优惠后总金额（支付金额），单位：元。币种：人民币
        /// </summary>
        [XmlElement("amount_discount")]
        public string AmountDiscount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }
    }
}
