using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChapterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChapterInfo : AopObject
    {
        /// <summary>
        /// 书籍（电子书）名称
        /// </summary>
        [XmlElement("book_name")]
        public string BookName { get; set; }

        /// <summary>
        /// 三方章节id
        /// </summary>
        [XmlElement("chapter_id")]
        public string ChapterId { get; set; }

        /// <summary>
        /// 章节名称
        /// </summary>
        [XmlElement("chapter_name")]
        public string ChapterName { get; set; }

        /// <summary>
        /// 章节顺序
        /// </summary>
        [XmlElement("chapter_order")]
        public long ChapterOrder { get; set; }

        /// <summary>
        /// 章节最新版本的审核状态，可能为空。（章节审核失败原因暂不支持）
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方书籍id
        /// </summary>
        [XmlElement("out_book_id")]
        public string OutBookId { get; set; }

        /// <summary>
        /// 章节的上下架状态以其对应的书籍为准，对C端用户展示
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
