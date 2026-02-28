using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndrFileInfo : AopObject
    {
        /// <summary>
        /// 文件格式
        /// </summary>
        [XmlElement("file_format")]
        public string FileFormat { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
