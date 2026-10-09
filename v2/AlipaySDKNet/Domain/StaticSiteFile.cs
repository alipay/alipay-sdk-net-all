using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StaticSiteFile Data Structure.
    /// </summary>
    [Serializable]
    public class StaticSiteFile : AopObject
    {
        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 文件大小
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
