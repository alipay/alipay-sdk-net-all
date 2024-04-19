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
        /// 文件下载地址过期时间，单位为秒，传0表示长期有效。注意：非公开(public-read) acl的文件无法获取长期有效的下载地址
        /// </summary>
        [XmlElement("expire")]
        public long Expire { get; set; }

        /// <summary>
        /// 文件ID(唯一)，文件的唯一索引ID，上传文件后系统会创建返回该文件的文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
