using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsInventoryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInventoryDetail : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 需要操作的库存数量; 当type为ADD类型,则对应库存增加该值,如果type为SUBTRACT则库存减去该值
        /// </summary>
        [XmlElement("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 操作库存类型枚举, ADD:加库存;  SUBTRACT: 减库存
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
