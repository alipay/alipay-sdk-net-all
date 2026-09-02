using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnhancedSameTypeReportInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnhancedSameTypeReportInfoDTO : AopObject
    {
        /// <summary>
        /// 医院名
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 报告Id
        /// </summary>
        [XmlElement("report_id")]
        public string ReportId { get; set; }

        /// <summary>
        /// 报告名
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告类型名称，医院提供非系统内枚举
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 分数，整数百分制，取值0-100分
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
