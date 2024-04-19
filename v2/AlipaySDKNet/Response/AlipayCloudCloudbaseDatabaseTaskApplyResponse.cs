using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseTaskApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseTaskApplyResponse : AopResponse
    {
        /// <summary>
        /// 导入任务url地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 导入/导出任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 导入任务id
        /// </summary>
        [XmlElement("upload_id")]
        public string UploadId { get; set; }

        /// <summary>
        /// 导入任务url地址
        /// </summary>
        [XmlElement("upload_url")]
        public string UploadUrl { get; set; }
    }
}
