using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuBean Data Structure.
    /// </summary>
    [Serializable]
    public class SkuBean : AopObject
    {
        /// <summary>
        /// 活动对象,购物车相关接口的活动视图
        /// </summary>
        [XmlElement("activity")]
        public CartActivityBean Activity { get; set; }

        /// <summary>
        /// 添加时间，1970至今毫秒值
        /// </summary>
        [XmlElement("add_time")]
        public long AddTime { get; set; }

        /// <summary>
        /// 价格，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 属性描述
        /// </summary>
        [XmlElement("attr_desc")]
        public string AttrDesc { get; set; }

        /// <summary>
        /// 库存，单位：个/份
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("item_attribute_list")]
        [XmlArrayItem("attribute_bean")]
        public List<AttributeBean> ItemAttributeList { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 原始价格，单位：元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 支付价格，单位：元
        /// </summary>
        [XmlElement("payment_price")]
        public string PaymentPrice { get; set; }

        /// <summary>
        /// 价格，单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量，单位：个/份
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 展示价格，单位：元
        /// </summary>
        [XmlElement("show_amt")]
        public string ShowAmt { get; set; }

        /// <summary>
        /// 加料列表
        /// </summary>
        [XmlArray("side_item_list")]
        [XmlArrayItem("side_item_bean")]
        public List<SideItemBean> SideItemList { get; set; }

        /// <summary>
        /// sku商品属性列表
        /// </summary>
        [XmlArray("sku_attribute_list")]
        [XmlArrayItem("attribute_bean")]
        public List<AttributeBean> SkuAttributeList { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 规格值，无法定义单位
        /// </summary>
        [XmlElement("spec_value")]
        public string SpecValue { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        [XmlElement("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// 单位价格，单位：元
        /// </summary>
        [XmlElement("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
