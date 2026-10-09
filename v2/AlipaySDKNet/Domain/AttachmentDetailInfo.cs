using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachmentDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AttachmentDetailInfo : AopObject
    {
        /// <summary>
        /// 附件标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 附件url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
