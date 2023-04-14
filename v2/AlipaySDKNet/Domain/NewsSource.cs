using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsSource Data Structure.
    /// </summary>
    [Serializable]
    public class NewsSource : AopObject
    {
        /// <summary>
        /// 作者名
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// 打标结果
        /// </summary>
        [XmlArray("concerned")]
        [XmlArrayItem("news_concerned")]
        public List<NewsConcerned> Concerned { get; set; }

        /// <summary>
        /// 原文链接
        /// </summary>
        [XmlElement("content_url")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// 文章指纹，此值相同表示为相似文章
        /// </summary>
        [XmlElement("doc_self_content_sign")]
        public string DocSelfContentSign { get; set; }

        /// <summary>
        /// 首发媒体名称
        /// </summary>
        [XmlElement("first_publish_media")]
        public string FirstPublishMedia { get; set; }

        /// <summary>
        /// 关键字高亮显示
        /// </summary>
        [XmlElement("highlight")]
        public KeywordsHighlight Highlight { get; set; }

        /// <summary>
        /// 图片资源列表
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 新闻来源的媒体
        /// </summary>
        [XmlElement("media_source")]
        public string MediaSource { get; set; }

        /// <summary>
        /// 文章中的实体列表
        /// </summary>
        [XmlArray("ner_entities")]
        [XmlArrayItem("news_ner_entity")]
        public List<NewsNerEntity> NerEntities { get; set; }

        /// <summary>
        /// 数据库中的唯一id
        /// </summary>
        [XmlElement("obj_id")]
        public string ObjId { get; set; }

        /// <summary>
        /// 文章发布时间
        /// </summary>
        [XmlElement("pub_time")]
        public string PubTime { get; set; }

        /// <summary>
        /// 文章提及的公司列表
        /// </summary>
        [XmlArray("related_companies")]
        [XmlArrayItem("news_related_company")]
        public List<NewsRelatedCompany> RelatedCompanies { get; set; }

        /// <summary>
        /// 文章全文
        /// </summary>
        [XmlElement("searchable_text")]
        public string SearchableText { get; set; }

        /// <summary>
        /// 舆情平台的新闻唯一id
        /// </summary>
        [XmlElement("source_doc_id")]
        public string SourceDocId { get; set; }

        /// <summary>
        /// 文档类型
        /// </summary>
        [XmlElement("source_doc_type")]
        public string SourceDocType { get; set; }

        /// <summary>
        /// 文章类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 文档摘要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
