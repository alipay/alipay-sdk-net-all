using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemInfoForFulfillmentList Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInfoForFulfillmentList : AopObject
    {
        /// <summary>
        /// 是否已删除，0：正常 1：删除
        /// </summary>
        [XmlElement("is_deleted")]
        public long IsDeleted { get; set; }

        /// <summary>
        /// saas关联的标品id（好大夫侧使用）
        /// </summary>
        [XmlElement("relation_spu_id")]
        public string RelationSpuId { get; set; }

        /// <summary>
        /// 外部商户的商品编码（对应商品的店内码）
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// saas商品id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// saas标品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
