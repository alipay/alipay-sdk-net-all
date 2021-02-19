using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArticleAttachmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleAttachmentInfo : AopObject
    {
        /// <summary>
        /// 文章附件
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 附件完整Key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 附件的url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
