using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchoolcontentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchoolcontentModifyModel : AopObject
    {
        /// <summary>
        /// 自动关联服务（默认true，推荐使用false）
        /// </summary>
        [XmlElement("auto_bind")]
        public bool AutoBind { get; set; }

        /// <summary>
        /// 来源应用ID
        /// </summary>
        [XmlElement("carrier_app_id")]
        public string CarrierAppId { get; set; }

        /// <summary>
        /// 来源链接
        /// </summary>
        [XmlElement("carrier_source_url")]
        public string CarrierSourceUrl { get; set; }

        /// <summary>
        /// 支付宝返回的内容唯一ID，修改时需要传入
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 详情链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 内容类型（text：纯文本、text_step：步骤文本、text_section：分段文本、image：图文、video：视频）
        /// </summary>
        [XmlElement("display_style")]
        public string DisplayStyle { get; set; }

        /// <summary>
        /// 图片信息
        /// </summary>
        [XmlArray("image_data")]
        [XmlArrayItem("string")]
        public List<string> ImageData { get; set; }

        /// <summary>
        /// 内容外部ID，要求唯一
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 已上架服务id列表
        /// </summary>
        [XmlArray("service_ids")]
        [XmlArrayItem("string")]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 学校描述
        /// </summary>
        [XmlArray("text_data")]
        [XmlArrayItem("string")]
        public List<string> TextData { get; set; }

        /// <summary>
        /// 视频信息
        /// </summary>
        [XmlArray("video_data")]
        [XmlArrayItem("string")]
        public List<string> VideoData { get; set; }
    }
}
