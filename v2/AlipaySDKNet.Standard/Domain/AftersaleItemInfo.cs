using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleItemInfo : AopObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 外部商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部skuid
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
