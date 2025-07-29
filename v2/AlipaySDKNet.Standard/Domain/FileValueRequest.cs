using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileValueRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FileValueRequest : AopObject
    {
        /// <summary>
        /// aftsId，为蚂蚁中间件返回
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小，单位B
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 文件类型,支持 "txt", "md", "mdx", "markdown", "pdf", "xlsx", "xls", "doc", "docx","csv", "eml", "msg", "pptx", "ppt", "epub"
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
