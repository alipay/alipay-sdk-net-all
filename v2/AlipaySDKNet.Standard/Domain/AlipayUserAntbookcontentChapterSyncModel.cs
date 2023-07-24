using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbookcontentChapterSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbookcontentChapterSyncModel : AopObject
    {
        /// <summary>
        /// 书籍ID，可唯一标识一个书籍
        /// </summary>
        [XmlElement("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// 章节是否免费标识
        /// </summary>
        [XmlElement("chapter_free")]
        public bool ChapterFree { get; set; }

        /// <summary>
        /// 章节ID，可唯一标识一个章节
        /// </summary>
        [XmlElement("chapter_id")]
        public string ChapterId { get; set; }

        /// <summary>
        /// 具体章节小说内容，正文部分
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 章节创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 章节最后一次修改时间
        /// </summary>
        [XmlElement("last_audit_time")]
        public string LastAuditTime { get; set; }

        /// <summary>
        /// 章节名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作类型 - ADD：新增操作 - UPDATE：更新操作
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 章节上架时间
        /// </summary>
        [XmlElement("shelves_time")]
        public string ShelvesTime { get; set; }

        /// <summary>
        /// 章节排序序号，必填且保证准确性
        /// </summary>
        [XmlElement("sort_no")]
        public long SortNo { get; set; }

        /// <summary>
        /// 章节标签
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 章节格式，仅支持HTML格式，若是TXT格式请按照下文章节内容标准进行转换，若是ePub等文件，暂不支持，若需支持请联系后端技术
        /// </summary>
        [XmlElement("text_format")]
        public string TextFormat { get; set; }

        /// <summary>
        /// 章节更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 卷ID，有卷则必填，可唯一标识一个卷
        /// </summary>
        [XmlElement("volume_id")]
        public string VolumeId { get; set; }

        /// <summary>
        /// 章节字数，有则必填
        /// </summary>
        [XmlElement("word_number")]
        public long WordNumber { get; set; }
    }
}
