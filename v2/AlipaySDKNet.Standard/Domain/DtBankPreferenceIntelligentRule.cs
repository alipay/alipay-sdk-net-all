using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankPreferenceIntelligentRule Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankPreferenceIntelligentRule : AopObject
    {
        /// <summary>
        /// 平均优惠金额，单位分
        /// </summary>
        [XmlElement("avg_discount_amount")]
        public long AvgDiscountAmount { get; set; }

        /// <summary>
        /// 优惠均价类型
        /// </summary>
        [XmlElement("avg_discount_amount_type")]
        public string AvgDiscountAmountType { get; set; }

        /// <summary>
        /// 指定周期均价配置列表，活动为指定周期均价配置时才会有返回值。
        /// </summary>
        [XmlArray("cycle_avg_discount_amount_config_list")]
        [XmlArrayItem("cycle_avg_discount_amount_config")]
        public List<CycleAvgDiscountAmountConfig> CycleAvgDiscountAmountConfigList { get; set; }

        /// <summary>
        /// 最大优惠金额，单位分
        /// </summary>
        [XmlElement("max_amount")]
        public long MaxAmount { get; set; }

        /// <summary>
        /// 最小优惠金额，单位分
        /// </summary>
        [XmlElement("min_amount")]
        public long MinAmount { get; set; }

        /// <summary>
        /// 智能立减优惠目标 moreUsers:覆盖更多用户 lowerAvgPrice:平均金额更低 MORE_GMV:交易规模更大 MORE_USER_RANGE:覆盖更多用户
        /// </summary>
        [XmlElement("optimization_target")]
        public string OptimizationTarget { get; set; }
    }
}
