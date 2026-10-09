using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemOrderBean Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderBean : AopObject
    {
        /// <summary>
        /// 数量：个
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("attribute_list")]
        [XmlArrayItem("attribute_bean")]
        public List<AttributeBean> AttributeList { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品订单ID
        /// </summary>
        [XmlElement("item_order_id")]
        public string ItemOrderId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商品原价,单位：元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 价格，单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量，单位：个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 加料商品列表
        /// </summary>
        [XmlArray("side_item_list")]
        [XmlArrayItem("side_item_bean")]
        public List<SideItemBean> SideItemList { get; set; }

        /// <summary>
        /// 商品的SKU
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品快照ID
        /// </summary>
        [XmlElement("snapshot_id")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 规格值，根据规格名称定义，无法给定具体单位
        /// </summary>
        [XmlElement("spec_value")]
        public string SpecValue { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        [XmlElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }
}
