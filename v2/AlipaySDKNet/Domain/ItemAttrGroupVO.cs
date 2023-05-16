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
        [XmlArray("product_attr_list")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> ProductAttrList { get; set; }

        /// <summary>
        /// 销售属性列表
        /// </summary>
        [XmlArray("sale_attr_list")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> SaleAttrList { get; set; }
    }
}
