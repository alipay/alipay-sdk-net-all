using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecificationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpecificationInfo : AopObject
    {
        /// <summary>
        /// 商品规格id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品库存
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品规格名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 价格，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
