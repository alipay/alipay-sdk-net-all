using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwAttachmentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwAttachmentCreateModel : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 文件全程，包含文件后缀
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 数据库id
        /// </summary>
        [XmlElement("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 可见范围，forward 或 inward
        /// </summary>
        [XmlElement("security")]
        public string Security { get; set; }

        /// <summary>
        /// 文件显示名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 可公网访问的文件地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
