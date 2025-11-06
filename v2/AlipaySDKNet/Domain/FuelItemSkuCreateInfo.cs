using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FuelItemSkuCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FuelItemSkuCreateInfo : AopObject
    {
        /// <summary>
        /// 成本价，单位：分
        /// </summary>
        [XmlElement("cost_price")]
        public long CostPrice { get; set; }

        /// <summary>
        /// 商品sku扩展
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("fuel_item_ext_info")]
        public List<FuelItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 外部SKU ID
        /// </summary>
        [XmlElement("external_sku_id")]
        public string ExternalSkuId { get; set; }

        /// <summary>
        /// 库存，单位：升
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 国标价，单位：分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商品实际售价，单位：分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }
    }
}
