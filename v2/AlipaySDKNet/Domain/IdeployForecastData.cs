using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdeployForecastData Data Structure.
    /// </summary>
    [Serializable]
    public class IdeployForecastData : AopObject
    {
        /// <summary>
        /// 业务线类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 时间间隔
        /// </summary>
        [XmlElement("period_interval")]
        public string PeriodInterval { get; set; }

        /// <summary>
        /// 预测结果数据
        /// </summary>
        [XmlElement("predict_result_value")]
        public string PredictResultValue { get; set; }

        /// <summary>
        /// 方案guid
        /// </summary>
        [XmlElement("scheme_guid")]
        public string SchemeGuid { get; set; }

        /// <summary>
        /// 测试方案
        /// </summary>
        [XmlElement("scheme_name")]
        public string SchemeName { get; set; }

        /// <summary>
        /// 技能组
        /// </summary>
        [XmlElement("skill_group")]
        public string SkillGroup { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
