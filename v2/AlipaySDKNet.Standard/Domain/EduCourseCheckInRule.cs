using System;
using System.Xml.Serialization;

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
    }
}
