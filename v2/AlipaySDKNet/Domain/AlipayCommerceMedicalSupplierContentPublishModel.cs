using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSupplierContentPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSupplierContentPublishModel : AopObject
    {
        /// <summary>
        /// 内容作者，预留字段，当前不透出给用户
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 外部内容ID，作为外部的唯一标识
        /// </summary>
        [XmlElement("biz_content_id")]
        public string BizContentId { get; set; }

        /// <summary>
        /// 内容正文
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 素材列表
        /// </summary>
        [XmlArray("media_info_list")]
        [XmlArrayItem("media_info")]
        public List<MediaInfo> MediaInfoList { get; set; }

        /// <summary>
        /// 来源文章的原始链接地址
        /// </summary>
        [XmlElement("original_link")]
        public string OriginalLink { get; set; }

        /// <summary>
        /// 和onwer_type搭配使用，当类型为生活号时传生活号ID(publishID)，当类型为作者ID时，好大夫医生ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 内容归属类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 内容分发范围。1 - 所有人可见，2 - 分发范围受限，默认是所有人可见
        /// </summary>
        [XmlElement("permission_status")]
        public string PermissionStatus { get; set; }

        /// <summary>
        /// 文章发布时间 仅支持 yyyy-MM-dd HH:mm:ss 格式， 且发布时间的范围为：大于相对于当前时间+15分钟，小于相对于当前时间+7天
        /// </summary>
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 内容来源，接入前找医疗频道分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 文章摘要；预留字段，当前不对用户透出
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
