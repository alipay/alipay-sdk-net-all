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
        /// 毕业月份
        /// </summary>
        [XmlElement("finish_school_month")]
        public string FinishSchoolMonth { get; set; }

        /// <summary>
        /// 毕业年份
        /// </summary>
        [XmlElement("finish_school_year")]
        public long FinishSchoolYear { get; set; }

        /// <summary>
        /// 入学月份
        /// </summary>
        [XmlElement("in_school_month")]
        public long InSchoolMonth { get; set; }

        /// <summary>
        /// 入学年份
        /// </summary>
        [XmlElement("in_school_year")]
        public long InSchoolYear { get; set; }

        /// <summary>
        /// 受教育地点
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 上学专业
        /// </summary>
        [XmlElement("major")]
        public string Major { get; set; }

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
        /// 是否统招
        /// </summary>
        [XmlElement("tong_zhao")]
        public bool TongZhao { get; set; }

        /// <summary>
        /// 年
        /// </summary>
        [XmlElement("year")]
        public long Year { get; set; }
    }
}
