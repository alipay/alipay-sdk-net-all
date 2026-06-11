using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthfulfillmentReportinterpretationQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthfulfillmentReportinterpretationQueryResponse : AopResponse
    {
        /// <summary>
        /// 报告解读结果
        /// </summary>
        [XmlElement("interpretation_result")]
        public ReportInterpretationDetailResponse InterpretationResult { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_list")]
        [XmlArrayItem("report_detail_response")]
        public List<ReportDetailResponse> ReportList { get; set; }
    }
}
