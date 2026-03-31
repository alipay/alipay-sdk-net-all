using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileList Data Structure.
    /// </summary>
    [Serializable]
    public class FileList : AopObject
    {
        /// <summary>
        /// 文件基于SHA_256计算出的哈希值
        /// </summary>
        [XmlElement("file_hash")]
        public string FileHash { get; set; }

        /// <summary>
        /// 文件的md5值
        /// </summary>
        [XmlElement("file_md_5")]
        public string FileMd5 { get; set; }

        /// <summary>
        /// 需要存证文件的名字
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小（字节）
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
