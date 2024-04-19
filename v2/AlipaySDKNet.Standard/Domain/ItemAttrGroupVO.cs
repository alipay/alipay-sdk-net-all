using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemAttrGroupVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemAttrGroupVO : AopObject
    {
        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("item_attr_list")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> ItemAttrList { get; set; }

        /// <summary>
        /// 商品属性列表 当前字段已废弃(商品模板标准升级，废弃改字段，请使用item_attr_list替换)
        /// </summary>
        [XmlArray("product_attr_list")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> ProductAttrList { get; set; }

        /// <summary>
        /// 销售属性列表 当前字段已废弃(商品模板标准升级，废弃改字段，请使用sku_attr_list替换)
        /// </summary>
        [XmlArray("sale_attr_list")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> SaleAttrList { get; set; }

        /// <summary>
        /// SKU属性列表
        /// </summary>
        [XmlArray("sku_attr_list")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> SkuAttrList { get; set; }

        /// <summary>
        /// 标品属性列表
        /// </summary>
        [XmlArray("spu_attr_list")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> SpuAttrList { get; set; }
    }
}
