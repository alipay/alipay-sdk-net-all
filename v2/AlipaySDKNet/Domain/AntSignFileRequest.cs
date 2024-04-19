using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignFileRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignFileRequest : AopObject
    {
        /// <summary>
        /// 文件可预览下载链接（业务方需保证文件存在和完整性） file_http_url和file_key 二选一，网关请求传递file_http_url
        /// </summary>
        [XmlElement("file_http_url")]
        public string FileHttpUrl { get; set; }

        /// <summary>
        /// 文件fileId 映射唯一的文件。多文件签署场景下，fileId必须唯一且和文件一一对应
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件osskey 通过oss上传的文件此值必传
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型，目前仅支持pdf，切勿传它值，默认传递：pdf
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
