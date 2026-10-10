using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbmtActivityInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class HbmtActivityInfoVO : AopObject
    {
        /// <summary>
        /// 活动通用描述
        /// </summary>
        [XmlElement("activity_description")]
        public string ActivityDescription { get; set; }

        /// <summary>
        /// 花呗商户合作活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// FLAT：统一比例模式，这种模式下所有亲密度等级下反花呗金比例一致；INTIMACY：亲密度模式这种模式下不同亲密度等级设置的反花呗金比例不同
        /// </summary>
        [XmlElement("calc_mode")]
        public string CalcMode { get; set; }

        /// <summary>
        /// 默认返金比例（百分比），两种反花呗金模式下的兜底比例
        /// </summary>
        [XmlElement("default_percentage")]
        public string DefaultPercentage { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 统一返金比例（百分比），如 "0.5" 表示 0.5%；仅 FLAT 模式返回
        /// </summary>
        [XmlElement("flat_ratio")]
        public string FlatRatio { get; set; }

        /// <summary>
        /// 单笔封顶值（花呗金币数）；0 表示不封顶
        /// </summary>
        [XmlElement("flat_ratio_cap")]
        public long FlatRatioCap { get; set; }

        /// <summary>
        /// 各等级返金比例，JSON 字符串，如 {"G1":"0.5","G2":"0.8"}；FLAT 模式下所有亲密度下的比例都是一样的
        /// </summary>
        [XmlElement("level_pricing")]
        public PreConsultMap LevelPricing { get; set; }

        /// <summary>
        /// 活动开始时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
