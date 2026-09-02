using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalReportEnhancedsametypeGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalReportEnhancedsametypeGetModel : AopObject
    {
        /// <summary>
        /// 主报告
        /// </summary>
        [XmlElement("main_report")]
        public ReportInfoDTO MainReport { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("other_reports")]
        [XmlArrayItem("report_info_d_t_o")]
        public List<ReportInfoDTO> OtherReports { get; set; }
    }
}
