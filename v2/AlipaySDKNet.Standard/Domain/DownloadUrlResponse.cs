using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DownloadUrlResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DownloadUrlResponse : AopObject
    {
        /// <summary>
        /// 文件下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
