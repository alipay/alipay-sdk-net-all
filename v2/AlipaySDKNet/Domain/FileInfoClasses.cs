using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileInfoClasses Data Structure.
    /// </summary>
    [Serializable]
    public class FileInfoClasses : AopObject
    {
        /// <summary>
        /// 文件产品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 文件链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
