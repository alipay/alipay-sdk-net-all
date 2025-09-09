using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSemesterInfoSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSemesterInfoSaveModel : AopObject
    {
        /// <summary>
        /// 学期结束日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 课时配置ID
        /// </summary>
        [XmlElement("period_id")]
        public string PeriodId { get; set; }

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

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
