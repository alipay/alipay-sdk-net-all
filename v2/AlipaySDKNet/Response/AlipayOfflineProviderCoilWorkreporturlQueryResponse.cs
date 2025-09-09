using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCoilWorkreporturlQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderCoilWorkreporturlQueryResponse : AopResponse
    {
        /// <summary>
        /// 报表文件对应的日期，值同请求传参中的report_date字段
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报表文件下载链接
        /// </summary>
        [XmlElement("report_file_url")]
        public string ReportFileUrl { get; set; }
    }
}
