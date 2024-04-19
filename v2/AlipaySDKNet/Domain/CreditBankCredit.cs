using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditBankCredit Data Structure.
    /// </summary>
    [Serializable]
    public class CreditBankCredit : AopObject
    {
        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 教育类别，枚举：成人高等教育（30），普通高等教育（31）
        /// </summary>
        [XmlElement("course_property")]
        public long CourseProperty { get; set; }

        /// <summary>
        /// 结果代码，枚举：（40=毕业，41=结业肄业）
        /// </summary>
        [XmlElement("course_result_code")]
        public long CourseResultCode { get; set; }

        /// <summary>
        /// 成绩
        /// </summary>
        [XmlElement("course_score")]
        public long CourseScore { get; set; }

        /// <summary>
        /// 毕业季代码（50=春，51=秋）
        /// </summary>
        [XmlElement("course_season")]
        public long CourseSeason { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        [XmlElement("course_subject")]
        public string CourseSubject { get; set; }

        /// <summary>
        /// 届别
        /// </summary>
        [XmlElement("course_year")]
        public string CourseYear { get; set; }

        /// <summary>
        /// 学分
        /// </summary>
        [XmlElement("credit")]
        public long Credit { get; set; }

        /// <summary>
        /// 学时
        /// </summary>
        [XmlElement("credit_hour")]
        public long CreditHour { get; set; }

        /// <summary>
        /// 获得成绩id
        /// </summary>
        [XmlElement("credit_outer_id")]
        public string CreditOuterId { get; set; }

        /// <summary>
        /// 获取时间，格式yyyy-mm-dd HH:mm:ss
        /// </summary>
        [XmlElement("experience_time")]
        public string ExperienceTime { get; set; }

        /// <summary>
        /// 办学机构
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 教育层次，枚举：本科（20），专科（21）
        /// </summary>
        [XmlElement("learning_stage")]
        public long LearningStage { get; set; }
    }
}
