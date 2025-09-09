using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportResult Data Structure.
    /// </summary>
    [Serializable]
    public class ReportResult : AopObject
    {
        /// <summary>
        /// 病例总结
        /// </summary>
        [XmlElement("case_summary")]
        public string CaseSummary { get; set; }

        /// <summary>
        /// KV抽取
        /// </summary>
        [XmlElement("kv")]
        public string Kv { get; set; }

        /// <summary>
        /// 报告类型
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// 报告子类别
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }
    }
}
