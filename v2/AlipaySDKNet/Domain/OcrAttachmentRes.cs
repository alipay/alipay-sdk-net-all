using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OcrAttachmentRes Data Structure.
    /// </summary>
    [Serializable]
    public class OcrAttachmentRes : AopObject
    {
        /// <summary>
        /// aq附件id
        /// </summary>
        [XmlElement("aq_id")]
        public string AqId { get; set; }

        /// <summary>
        /// aq附件类型
        /// </summary>
        [XmlElement("aq_type")]
        public string AqType { get; set; }

        /// <summary>
        /// aq附件地址
        /// </summary>
        [XmlElement("aq_url")]
        public string AqUrl { get; set; }

        /// <summary>
        /// 附件id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// OCR结果
        /// </summary>
        [XmlElement("ocr_res")]
        public string OcrRes { get; set; }

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
