using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DownloadUrlRequest Data Structure.
    /// </summary>
    [Serializable]
    public class DownloadUrlRequest : AopObject
    {
        /// <summary>
        /// 文件下载地址过期时间，传0表示长期有效
        /// </summary>
        [XmlElement("expire")]
        public long Expire { get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
