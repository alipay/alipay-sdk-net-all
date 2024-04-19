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
        /// 文件ID(唯一)，文件的唯一索引ID，上传文件后系统会创建返回该文件的文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
