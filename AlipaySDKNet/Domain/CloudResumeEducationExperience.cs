using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudResumeEducationExperience Data Structure.
    /// </summary>
    [Serializable]
    public class CloudResumeEducationExperience : AopObject
    {
        /// <summary>
        /// 学历
        /// </summary>
        [XmlElement("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 教育状态
        /// </summary>
        [XmlElement("education_status")]
        public string EducationStatus { get; set; }

        /// <summary>
        /// 受教育地点
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 月
        /// </summary>
        [XmlElement("month")]
        public long Month { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 年
        /// </summary>
        [XmlElement("year")]
        public long Year { get; set; }
    }
}
