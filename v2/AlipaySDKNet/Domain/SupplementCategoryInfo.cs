using System;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        /// 当补充项为“其他资料”时，需细化返回相应的其他资料内容
        /// </summary>
        [XmlArray("supplement_details_list")]
        [XmlArrayItem("string")]
        public List<string> SupplementDetailsList { get; set; }

        /// <summary>
        /// 需要补充的流水金额，单位分。
        /// </summary>
        [XmlElement("supplement_payment_amt")]
        public long SupplementPaymentAmt { get; set; }
    }
}
