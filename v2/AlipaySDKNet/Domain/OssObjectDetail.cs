using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OssObjectDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OssObjectDetail : AopObject
    {
        /// <summary>
        /// 文件创建时间，格式为0时区iso8601格式
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 文件ID(唯一)，文件的唯一索引ID，上传文件后系统会创建返回该文件的文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小，单位为Byte
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 文件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
