using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemInfos Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInfos : AopObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
