using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftTemplateStoryBox Data Structure.
    /// </summary>
    [Serializable]
    public class GiftTemplateStoryBox : AopObject
    {
        /// <summary>
        /// 商家跳转链接描述，用于红包详情页
        /// </summary>
        [XmlElement("link_show_memo")]
        public string LinkShowMemo { get; set; }

        /// <summary>
        /// 红包详情页商家跳转链接
        /// </summary>
        [XmlElement("link_to_merchant")]
        public string LinkToMerchant { get; set; }

        /// <summary>
        /// 封面故事描述，用于红包详情页
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 封面故事视觉资源列表，包含图片、视频等，用于红包详情页
        /// </summary>
        [XmlArray("resources")]
        [XmlArrayItem("gift_template_meta_info")]
        public List<GiftTemplateMetaInfo> Resources { get; set; }
    }
}
