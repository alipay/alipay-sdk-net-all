using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSku Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSku : AopObject
    {
        /// <summary>
        /// 原价，单位分。 字段值需要大于或等于sale_price。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 外部SKU编码
        /// </summary>
        [XmlElement("out_sku_code")]
        public string OutSkuCode { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// SKU属性列表，具体所需属性见类目模版查询接口
        /// </summary>
        [XmlArray("sku_attrs")]
        [XmlArrayItem("item_sku_attr")]
        public List<ItemSkuAttr> SkuAttrs { get; set; }

        /// <summary>
        /// 平台SKU编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
