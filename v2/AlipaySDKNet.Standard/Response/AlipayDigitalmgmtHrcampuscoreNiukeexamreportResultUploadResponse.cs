using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrcampuscoreNiukeexamreportResultUploadResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrcampuscoreNiukeexamreportResultUploadResponse : AopResponse
    {
        /// <summary>
        /// 牛客笔试报告回调结果
        /// </summary>
        [XmlElement("niuke_exam_report_callback_result")]
        public NiukeExamReportCallbackResult NiukeExamReportCallbackResult { get; set; }

        /// <summary>
        /// 服务调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
