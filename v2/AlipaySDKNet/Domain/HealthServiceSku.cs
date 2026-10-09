using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthServiceSku Data Structure.
    /// </summary>
    [Serializable]
    public class HealthServiceSku : AopObject
    {
        /// <summary>
        /// 商家sku条形码
        /// </summary>
        [XmlElement("merchant_item_sku_bar_code")]
        public string MerchantItemSkuBarCode { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
