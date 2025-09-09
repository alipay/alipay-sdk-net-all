using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayWidgetCardTplItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayWidgetCardTplItemInfo : AopObject
    {
        /// <summary>
        /// 补全的内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 2:平台补全 1:业务补全 0:无需补全
        /// </summary>
        [XmlElement("content_fill_mode")]
        public string ContentFillMode { get; set; }

        /// <summary>
        /// 动态key，同卡片模板下唯一
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 在统一区域内需要滑动展示多个的情况需要该值
        /// </summary>
        [XmlArray("key_list")]
        [XmlArrayItem("alipay_widget_card_tpl_item_simplify_info")]
        public List<AlipayWidgetCardTplItemSimplifyInfo> KeyList { get; set; }

        /// <summary>
        /// 个数限制
        /// </summary>
        [XmlElement("limit_size")]
        public string LimitSize { get; set; }

        /// <summary>
        /// 基础类型：图片、文字、图标、按钮、列表、链接、背景等
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 补全的跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 2:平台补全 1:业务补全 0:无需补全
        /// </summary>
        [XmlElement("url_fill_mode")]
        public string UrlFillMode { get; set; }
    }
}
