using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuditEvidenceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuditEvidenceInfo : AopObject
    {
        /// <summary>
        /// 文件类型。包括.jpg .png .jpeg .pdf等
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
