using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemBean Data Structure.
    /// </summary>
    [Serializable]
    public class ItemBean : AopObject
    {
        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("attribute_list")]
        [XmlArrayItem("attribute_bean")]
        public List<AttributeBean> AttributeList { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品优惠
        /// </summary>
        [XmlElement("item_discount_sku")]
        public DiscountSkuBean ItemDiscountSku { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品排序
        /// </summary>
        [XmlElement("item_sort")]
        public long ItemSort { get; set; }

        /// <summary>
        /// 商品分类ID
        /// </summary>
        [XmlElement("menu_id")]
        public string MenuId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原始SKU
        /// </summary>
        [XmlElement("origin_sku")]
        public OriginSkuBean OriginSku { get; set; }

        /// <summary>
        /// 当前库存数量，单位：份/个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// true/false -- 当且仅当 true 时才是必选，false 或者字段不存在，都表示非必选商品
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 展示类型
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }

        /// <summary>
        /// 加料商品列表
        /// </summary>
        [XmlArray("side_item_list")]
        [XmlArrayItem("side_item_bean")]
        public List<SideItemBean> SideItemList { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_bean")]
        public List<SkuBean> SkuList { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 商品缩略图
        /// </summary>
        [XmlElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }
}
