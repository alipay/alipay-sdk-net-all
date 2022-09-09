using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftTemplateBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GiftTemplateBaseInfo : AopObject
    {
        /// <summary>
        /// 会话气泡图片
        /// </summary>
        [XmlElement("card_image_url")]
        public string CardImageUrl { get; set; }

        /// <summary>
        /// 获取同款链接描述文案，用于封面详情页
        /// </summary>
        [XmlElement("link_show_memo")]
        public string LinkShowMemo { get; set; }

        /// <summary>
        /// 获取该封面的链接
        /// </summary>
        [XmlElement("link_to_get")]
        public string LinkToGet { get; set; }

        /// <summary>
        /// 封面祝福语
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 封面名称，”我的封面“页面展示用
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分享描述文案
        /// </summary>
        [XmlElement("share_desc")]
        public string ShareDesc { get; set; }

        /// <summary>
        /// 分享标题
        /// </summary>
        [XmlElement("share_title")]
        public string ShareTitle { get; set; }

        /// <summary>
        /// 分享链接
        /// </summary>
        [XmlElement("share_url")]
        public string ShareUrl { get; set; }

        /// <summary>
        /// 封面缩略图，用于发红包表单页
        /// </summary>
        [XmlElement("template_form_thumbnail_url")]
        public string TemplateFormThumbnailUrl { get; set; }

        /// <summary>
        /// 封面缩略图，用于发红包页
        /// </summary>
        [XmlElement("template_thumbnail")]
        public string TemplateThumbnail { get; set; }
    }
}
