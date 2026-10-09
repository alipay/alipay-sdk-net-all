using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduCourseCheckInRule Data Structure.
    /// </summary>
    [Serializable]
    public class EduCourseCheckInRule : AopObject
    {
        /// <summary>
        /// 自动刷新二维码
        /// </summary>
        [XmlElement("automatic_refresh")]
        public bool AutomaticRefresh { get; set; }

        /// <summary>
        /// 课程描述
        /// </summary>
        [XmlElement("course_desc")]
        public string CourseDesc { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 课程签到规则ID
        /// </summary>
        [XmlElement("course_rule_id")]
        public string CourseRuleId { get; set; }

        /// <summary>
        /// 课程签到规则名称
        /// </summary>
        [XmlElement("course_rule_name")]
        public string CourseRuleName { get; set; }

        /// <summary>
        /// 每周天次，用1-7分别表示周一到周日
        /// </summary>
        [XmlElement("day_of_week")]
        public long DayOfWeek { get; set; }

        /// <summary>
        /// 签到规则信息
        /// </summary>
        [XmlElement("edu_check_in_rule")]
        public EduCheckInRuleConfig EduCheckInRule { get; set; }

        /// <summary>
        /// 启用课程规则
        /// </summary>
        [XmlElement("enable_course_rule")]
        public bool EnableCourseRule { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 手动关闭标识
        /// </summary>
        [XmlElement("manual_close")]
        public bool ManualClose { get; set; }

        /// <summary>
        /// 课时节次，即每天第几节课，与课时配置保持一致
        /// </summary>
        [XmlArray("period_no_list")]
        [XmlArrayItem("number")]
        public List<long> PeriodNoList { get; set; }

        /// <summary>
        /// 刷新二维码频率（单位：秒）
        /// </summary>
        [XmlElement("refresh_qr_code_frequency")]
        public long RefreshQrCodeFrequency { get; set; }

        /// <summary>
        /// 学期描述
        /// </summary>
        [XmlElement("semester_desc")]
        public string SemesterDesc { get; set; }

        /// <summary>
        /// 学期id
        /// </summary>
        [XmlElement("semester_id")]
        public string SemesterId { get; set; }

        /// <summary>
        /// 学期名称
        /// </summary>
        [XmlElement("semester_name")]
        public string SemesterName { get; set; }

        /// <summary>
        /// 学期周次列表，即课程在本学期的哪些周上课
        /// </summary>
        [XmlArray("week_list")]
        [XmlArrayItem("number")]
        public List<long> WeekList { get; set; }
    }
}
