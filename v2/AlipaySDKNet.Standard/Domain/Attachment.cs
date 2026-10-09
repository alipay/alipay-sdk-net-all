using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Attachment Data Structure.
    /// </summary>
    [Serializable]
    public class Attachment : AopObject
    {
        /// <summary>
        /// 流程附件名称
        /// </summary>
        [XmlElement("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 流程附件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
