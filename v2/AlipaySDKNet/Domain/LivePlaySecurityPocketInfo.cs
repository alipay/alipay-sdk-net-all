using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LivePlaySecurityPocketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LivePlaySecurityPocketInfo : AopObject
    {
        /// <summary>
        /// 商品描述内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 当前商品的唯一标识
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品类型 ITEM-商品，SERVICE-服务
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
