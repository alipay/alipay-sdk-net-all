using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwArticleCreateModel : AopObject
    {
        /// <summary>
        /// 附件列表
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("article_attachment_info")]
        public List<ArticleAttachmentInfo> Attachments { get; set; }

        /// <summary>
        /// 所属类目ID，如果search_all_category为true则不用填
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展标题
        /// </summary>
        [XmlArray("extend_titles")]
        [XmlArrayItem("string")]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [XmlElement("library_id")]
        public string LibraryId { get; set; }

        /// <summary>
        /// 默认为 2999-12-31 23:59:59
        /// </summary>
        [XmlElement("publish_end")]
        public string PublishEnd { get; set; }

        /// <summary>
        /// 默认为当前时间
        /// </summary>
        [XmlElement("publish_start")]
        public string PublishStart { get; set; }

        /// <summary>
        /// 关联知识点
        /// </summary>
        [XmlArray("related_articles")]
        [XmlArrayItem("base_article_info")]
        public List<BaseArticleInfo> RelatedArticles { get; set; }

        /// <summary>
        /// 场景ID。KNOWLEDGE（内部知识库）；ROBOT（机器人）;HELP（帮助中心）；WHELP（无线帮助中心）
        /// </summary>
        [XmlArray("scene_codes")]
        [XmlArrayItem("string")]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
