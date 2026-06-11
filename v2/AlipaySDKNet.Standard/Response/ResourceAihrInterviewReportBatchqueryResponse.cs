using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ResourceAihrInterviewReportBatchqueryResponse.
    /// </summary>
    public class ResourceAihrInterviewReportBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_list")]
        [XmlArrayItem("openapi_interview_report_item_d_t_o")]
        public List<OpenapiInterviewReportItemDTO> ReportList { get; set; }
    }
}
