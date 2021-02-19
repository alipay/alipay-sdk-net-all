using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleGetResponse.
    /// </summary>
    public class AlipayIserviceCcmSwArticleGetResponse : AopResponse
    {
        /// <summary>
        /// 文章对应附件集合
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("article_attachment_info")]
        public List<ArticleAttachmentInfo> Attachments { get; set; }

        /// <summary>
        /// 所属类目ID
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 类目名称路径
        /// </summary>
        [XmlElement("category_name_path")]
        public string CategoryNamePath { get; set; }

        /// <summary>
        /// 类目路径
        /// </summary>
        [XmlArray("category_path")]
        [XmlArrayItem("article_category_info")]
        public List<ArticleCategoryInfo> CategoryPath { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 扩展标题
        /// </summary>
        [XmlArray("extend_titles")]
        [XmlArrayItem("string")]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 文章ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

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
        public long LibraryId { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [XmlElement("order_no")]
        public long OrderNo { get; set; }

        /// <summary>
        /// 文章对应图片集合
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("article_attachment_info")]
        public List<ArticleAttachmentInfo> Pictures { get; set; }

        /// <summary>
        /// 有效期止
        /// </summary>
        [XmlElement("publish_end")]
        public string PublishEnd { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        [XmlElement("publish_start")]
        public string PublishStart { get; set; }

        /// <summary>
        /// 场景ID。1（内部知识库）；2（机器人）;3（帮助中心）；4（无线帮助中心）
        /// </summary>
        [XmlArray("scene_codes")]
        [XmlArrayItem("string")]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 文章状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 文章状态码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("updater_id")]
        public string UpdaterId { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        [XmlElement("updater_name")]
        public string UpdaterName { get; set; }
    }
}
