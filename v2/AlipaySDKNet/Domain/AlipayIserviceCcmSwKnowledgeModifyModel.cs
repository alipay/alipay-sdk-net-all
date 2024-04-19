using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwKnowledgeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwKnowledgeModifyModel : AopObject
    {
        /// <summary>
        /// 所属类目ID
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 知识点所属类目
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 知识点答案内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 外部知识点ID
        /// </summary>
        [XmlElement("ext_id")]
        public string ExtId { get; set; }

        /// <summary>
        /// 扩展标题（问法）
        /// </summary>
        [XmlArray("extend_titles")]
        [XmlArrayItem("string")]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 问答关联图片附件地址
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 知识点ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 默认为false，为true且id非空时，表示删除知识点
        /// </summary>
        [XmlElement("is_delete")]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 是否被检索到，默认false，系统希望为true
        /// </summary>
        [XmlElement("is_searchable")]
        public bool IsSearchable { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [XmlElement("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [XmlElement("library_name")]
        public string LibraryName { get; set; }

        /// <summary>
        /// 关联商品信息
        /// </summary>
        [XmlElement("spu")]
        public SpuDetail Spu { get; set; }

        /// <summary>
        /// 以逗号分割的字符串列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 知识点标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
