using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalReportSametypeGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalReportSametypeGetResponse : AopResponse
    {
        /// <summary>
        /// 主报告
        /// </summary>
        [XmlElement("main_report")]
        public ReportInfoDTO MainReport { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("same_type_report")]
        [XmlArrayItem("same_type_report_info_d_t_o")]
        public List<SameTypeReportInfoDTO> SameTypeReport { get; set; }
    }
}
