using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FileDTO : AopObject
    {
        /// <summary>
        /// 附件下载地址
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }
    }
}
