using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MergeInfoE Data Structure.
    /// </summary>
    [Serializable]
    public class MergeInfoE : AopObject
    {
        /// <summary>
        /// 合并优惠金额，单位：元
        /// </summary>
        [XmlElement("merge_discount_amount")]
        public string MergeDiscountAmount { get; set; }

        /// <summary>
        /// 合并期数/月
        /// </summary>
        [XmlElement("merge_period")]
        public string MergePeriod { get; set; }

        /// <summary>
        ///  合并租金金额，单位：元
        /// </summary>
        [XmlElement("merge_rent_amount")]
        public string MergeRentAmount { get; set; }

        /// <summary>
        /// 原始期数，月
        /// </summary>
        [XmlElement("original_period")]
        public string OriginalPeriod { get; set; }
    }
}
