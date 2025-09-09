using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFhyeduLearnplanSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFhyeduLearnplanSyncModel : AopObject
    {
        /// <summary>
        /// 布置时间
        /// </summary>
        [XmlElement("assign_time")]
        public string AssignTime { get; set; }

        /// <summary>
        /// 课后学习计划
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [XmlElement("dead_line_time")]
        public string DeadLineTime { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [XmlElement("homework_id")]
        public string HomeworkId { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学员id
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }
    }
}
