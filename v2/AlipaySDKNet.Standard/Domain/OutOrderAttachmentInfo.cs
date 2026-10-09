using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutOrderAttachmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutOrderAttachmentInfo : AopObject
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }
    }
}
