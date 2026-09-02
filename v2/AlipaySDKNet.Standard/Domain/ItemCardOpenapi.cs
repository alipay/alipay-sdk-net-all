using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCardOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCardOpenapi : AopObject
    {
        /// <summary>
        /// 支测商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("item_image")]
        public string ItemImage { get; set; }

        /// <summary>
        /// 券后价，单位：元
        /// </summary>
        [XmlElement("item_original_price")]
        public string ItemOriginalPrice { get; set; }

        /// <summary>
        /// 券后价，单位：元
        /// </summary>
        [XmlElement("item_safe_price")]
        public string ItemSafePrice { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_tags")]
        [XmlArrayItem("string")]
        public List<string> ItemTags { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品跳转链接
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }
    }
}
