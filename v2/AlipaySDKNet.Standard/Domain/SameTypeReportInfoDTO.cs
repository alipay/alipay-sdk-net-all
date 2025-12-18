using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SameTypeReportInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SameTypeReportInfoDTO : AopObject
    {
        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 报告id
        /// </summary>
        [XmlElement("report_id")]
        public string ReportId { get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告类型
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 同类型分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 检查时间
        /// </summary>
        [XmlElement("treatment_time")]
        public string TreatmentTime { get; set; }
    }
}
