using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentReportIdentifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentReportIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 报告识别结果
        /// </summary>
        [XmlElement("data")]
        public ReportResult Data { get; set; }
    }
}
