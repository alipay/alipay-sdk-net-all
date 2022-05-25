using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FileInfoDTO : AopObject
    {
        /// <summary>
        /// 加密方式
        /// </summary>
        [XmlElement("encode_type")]
        public string EncodeType { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
