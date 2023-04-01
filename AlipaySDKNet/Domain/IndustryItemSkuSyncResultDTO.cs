using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryItemSkuSyncResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryItemSkuSyncResultDTO : AopObject
    {
        /// <summary>
        /// 支付宝侧skuId
        /// </summary>
        [XmlElement("platform_sku_id")]
        public string PlatformSkuId { get; set; }

        /// <summary>
        /// 商户侧skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
