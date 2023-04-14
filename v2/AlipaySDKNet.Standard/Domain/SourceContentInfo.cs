using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SourceContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SourceContentInfo : AopObject
    {
        /// <summary>
        /// 内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 支付宝内容链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 内容分发范围。0 - 仅创作者自己可见，1 - 所有人可见，2 - 分发范围受限。
        /// </summary>
        [XmlElement("permission_status")]
        public string PermissionStatus { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("source_author")]
        public string SourceAuthor { get; set; }

        /// <summary>
        /// 来源文章的原始链接地址
        /// </summary>
        [XmlElement("source_link")]
        public string SourceLink { get; set; }

        /// <summary>
        /// 素材列表
        /// </summary>
        [XmlArray("source_media_infos")]
        [XmlArrayItem("source_media_info")]
        public List<SourceMediaInfo> SourceMediaInfos { get; set; }

        /// <summary>
        /// 关联服务
        /// </summary>
        [XmlArray("source_offers")]
        [XmlArrayItem("source_offer")]
        public List<SourceOffer> SourceOffers { get; set; }

        /// <summary>
        /// 文章发布时间
        /// </summary>
        [XmlElement("source_publish_date")]
        public string SourcePublishDate { get; set; }

        /// <summary>
        /// 内容状态 0-审核中 1-成功发布 2-审核不通过 3-己删除
        /// </summary>
        [XmlElement("source_status")]
        public string SourceStatus { get; set; }

        /// <summary>
        /// 文章的摘要
        /// </summary>
        [XmlElement("source_summary")]
        public string SourceSummary { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [XmlElement("source_title")]
        public string SourceTitle { get; set; }

        /// <summary>
        /// 内容类型（0-长图文 1-短图文 2-视频）
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 平台加工后的内容标签，例如 HIGH_QUALITY: 优质
        /// </summary>
        [XmlArray("special_tags")]
        [XmlArrayItem("string")]
        public List<string> SpecialTags { get; set; }
    }
}
