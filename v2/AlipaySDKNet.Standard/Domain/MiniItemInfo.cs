using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniItemInfo : AopObject
    {
        /// <summary>
        /// 商品头图
        /// </summary>
        [XmlElement("head_img_url")]
        public string HeadImgUrl { get; set; }

        /// <summary>
        /// 平台侧商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品类型描述
        /// </summary>
        [XmlElement("item_type_desc")]
        public string ItemTypeDesc { get; set; }

        /// <summary>
        /// 商家侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
