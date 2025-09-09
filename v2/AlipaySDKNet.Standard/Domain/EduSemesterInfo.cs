using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduSemesterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduSemesterInfo : AopObject
    {
        /// <summary>
        /// 学期结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学期最大周数
        /// </summary>
        [XmlElement("max_week")]
        public long MaxWeek { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 关联课时
        /// </summary>
        [XmlElement("period")]
        public EduPeriodInfo Period { get; set; }

        /// <summary>
        /// 学期描述
        /// </summary>
        [XmlElement("semester_desc")]
        public string SemesterDesc { get; set; }

        /// <summary>
        /// 学期ID
        /// </summary>
        [XmlElement("semester_id")]
        public string SemesterId { get; set; }

        /// <summary>
        /// 学期名称
        /// </summary>
        [XmlElement("semester_name")]
        public string SemesterName { get; set; }

        /// <summary>
        /// 学期开始日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
