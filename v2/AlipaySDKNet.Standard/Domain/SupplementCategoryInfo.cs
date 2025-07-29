using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplementCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SupplementCategoryInfo : AopObject
    {
        /// <summary>
        /// 需要补充信息的类别
        /// </summary>
        [XmlElement("supplement_category")]
        public string SupplementCategory { get; set; }

        /// <summary>
        /// 需要补充的流水金额，单位分。
        /// </summary>
        [XmlElement("supplement_payment_amt")]
        public long SupplementPaymentAmt { get; set; }
    }
}
