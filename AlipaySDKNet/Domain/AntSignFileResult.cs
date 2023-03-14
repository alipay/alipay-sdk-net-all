using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignFileResult Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignFileResult : AopObject
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件osskey
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件http链接
        /// </summary>
        [XmlElement("http_file_url")]
        public string HttpFileUrl { get; set; }
    }
}
