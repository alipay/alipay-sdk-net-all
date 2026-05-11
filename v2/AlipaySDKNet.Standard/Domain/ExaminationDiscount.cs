using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationDiscount Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationDiscount : AopObject
    {
        /// <summary>
        /// 优惠金额，单位：元。币种：人民币
        /// </summary>
        [XmlElement("amount_discount")]
        public string AmountDiscount { get; set; }
    }
}
