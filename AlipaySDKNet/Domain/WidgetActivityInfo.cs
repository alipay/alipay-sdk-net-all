using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WidgetActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetActivityInfo : AopObject
    {
        /// <summary>
        /// 活动点击跳转到小程序的链接地址
        /// </summary>
        [XmlElement("activity_click_url")]
        public string ActivityClickUrl { get; set; }

        /// <summary>
        /// 活动的唯一标识，同一个小程序橱窗下，该标识唯一，请开发者自行保证
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动图片链接,最多不能超过5个
        /// </summary>
        [XmlArray("activity_picture_urls")]
        [XmlArrayItem("string")]
        public List<string> ActivityPictureUrls { get; set; }
    }
}
