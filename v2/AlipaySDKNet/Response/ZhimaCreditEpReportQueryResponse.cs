using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpReportQueryResponse.
    /// </summary>
    public class ZhimaCreditEpReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 信用报告的下载链接
        /// </summary>
        [XmlElement("report_url")]
        public string ReportUrl { get; set; }
    }
}
