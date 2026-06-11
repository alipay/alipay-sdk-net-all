using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenapiInterviewReportItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenapiInterviewReportItemDTO : AopObject
    {
        /// <summary>
        /// 面试间ID
        /// </summary>
        [XmlElement("ai_interview_id")]
        public string AiInterviewId { get; set; }

        /// <summary>
        /// 面试状态
        /// </summary>
        [XmlElement("ai_interview_status")]
        public string AiInterviewStatus { get; set; }

        /// <summary>
        /// 面试评语
        /// </summary>
        [XmlElement("report_comment")]
        public string ReportComment { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_comment_all")]
        [XmlArrayItem("report_comment_detail_d_t_o")]
        public List<ReportCommentDetailDTO> ReportCommentAll { get; set; }

        /// <summary>
        /// 百分制
        /// </summary>
        [XmlElement("report_score")]
        public long ReportScore { get; set; }

        /// <summary>
        /// 报告链接
        /// </summary>
        [XmlElement("report_url")]
        public string ReportUrl { get; set; }
    }
}
