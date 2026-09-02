using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeDetailE Data Structure.
    /// </summary>
    [Serializable]
    public class TradeDetailE : AopObject
    {
        /// <summary>
        /// 免押必过；设置后，不会过风控，谨慎设置；仅支持设置值"Y"，不支持其他值
        /// </summary>
        [XmlElement("credit_must_pass")]
        public string CreditMustPass { get; set; }

        /// <summary>
        /// 扣款信息
        /// </summary>
        [XmlElement("deduction_info")]
        public DeductionInfoE DeductionInfo { get; set; }

        /// <summary>
        /// 灵活租期交易信息
        /// </summary>
        [XmlElement("flexible_rent_info")]
        public FlexibleRentInfo FlexibleRentInfo { get; set; }

        /// <summary>
        /// 合并信息
        /// </summary>
        [XmlElement("merge_info")]
        public MergeInfoE MergeInfo { get; set; }

        /// <summary>
        /// 拆分信息
        /// </summary>
        [XmlElement("split_info")]
        public SplitInfoE SplitInfo { get; set; }
    }
}
