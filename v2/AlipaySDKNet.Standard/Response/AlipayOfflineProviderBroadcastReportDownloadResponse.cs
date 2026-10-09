using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastReportDownloadResponse.
    /// </summary>
    public class AlipayOfflineProviderBroadcastReportDownloadResponse : AopResponse
    {
        /// <summary>
        /// 查询音响数据报表下载地址，当报表未生成时不会返回值
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 待下载报表文件大小，单位为：字节
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 实际查询的报表日期
        /// </summary>
        [XmlElement("report_dt")]
        public string ReportDt { get; set; }

        /// <summary>
        /// 表示该导出任务的响应状态，正常响应状态：PROCESSING、COMPLETED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 对报表状态的解释，不返回错误信息
        /// </summary>
        [XmlElement("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 报表任务唯一标识
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
