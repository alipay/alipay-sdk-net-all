using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HmStageReport Data Structure.
    /// </summary>
    [Serializable]
    public class HmStageReport : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 报告正文(Markdown)
        /// </summary>
        [XmlElement("content_markdown")]
        public string ContentMarkdown { get; set; }

        /// <summary>
        /// 周期结束
        /// </summary>
        [XmlElement("period_end")]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// 周期序号
        /// </summary>
        [XmlElement("period_index")]
        public long PeriodIndex { get; set; }

        /// <summary>
        /// 周期开始
        /// </summary>
        [XmlElement("period_start")]
        public string PeriodStart { get; set; }

        /// <summary>
        /// 报告 ID
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
        /// 报告生成时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }
    }
}
