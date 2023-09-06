using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryItemInfoVO : AopObject
    {
        /// <summary>
        /// 商户商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户商品sku_id
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
