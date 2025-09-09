using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduCheckInRuleConfig Data Structure.
    /// </summary>
    [Serializable]
    public class EduCheckInRuleConfig : AopObject
    {
        /// <summary>
        /// 规则扩展信息
        /// </summary>
        [XmlElement("course_config_ext")]
        public EduCheckInRuleConfigExt CourseConfigExt { get; set; }

        /// <summary>
        /// 规则生效状态
        /// </summary>
        [XmlElement("enable_status")]
        public bool EnableStatus { get; set; }

        /// <summary>
        /// 签到结束时间，格式：HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 签到频率类型
        /// </summary>
        [XmlElement("frequency_type")]
        public string FrequencyType { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 是否启用拍照校验
        /// </summary>
        [XmlElement("picture_check")]
        public bool PictureCheck { get; set; }

        /// <summary>
        /// 是否启用位置校验
        /// </summary>
        [XmlElement("place_check")]
        public bool PlaceCheck { get; set; }

        /// <summary>
        /// 签到半径，单位米
        /// </summary>
        [XmlElement("radius")]
        public long Radius { get; set; }

        /// <summary>
        /// 签到规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 签到规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 签到规则类型
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 签到开始时间，格式：HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 周天列表，数字1-7分别表示周一到周日。
        /// </summary>
        [XmlArray("week_day_list")]
        [XmlArrayItem("number")]
        public List<long> WeekDayList { get; set; }
    }
}
