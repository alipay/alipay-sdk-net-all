using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OcrAttachment Data Structure.
    /// </summary>
    [Serializable]
    public class OcrAttachment : AopObject
    {
        /// <summary>
        /// 附件id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 附件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
