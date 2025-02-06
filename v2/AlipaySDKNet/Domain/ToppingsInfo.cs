using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ToppingsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ToppingsInfo : AopObject
    {
        /// <summary>
        /// 加料分类名称 当前字段已废弃(参数名错误，调整成category_name字段)
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 加料分类id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 加料分类名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 加料份数，单位份
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 加料商品id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 加料商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品goods id 当前字段已废弃(错误字段，改为goods_id字段)
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 加料图片
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 商品加料库存，单位份
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品加料名称 当前字段已废弃(错误字段，替换成goods_name字段)
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 加料可选规格
        /// </summary>
        [XmlArray("optional_specifications")]
        [XmlArrayItem("specification_info")]
        public List<SpecificationInfo> OptionalSpecifications { get; set; }

        /// <summary>
        /// 商品加料价格，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品加料skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 加料规格id，订单计算接口需传入该参数
        /// </summary>
        [XmlElement("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 加料规格名称，订单计算接口需传入该参数
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 商品加料名称
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
