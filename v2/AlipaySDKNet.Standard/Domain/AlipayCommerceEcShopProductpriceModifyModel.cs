using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShopProductpriceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShopProductpriceModifyModel : AopObject
    {
        /// <summary>
        /// 商家企业 ID，用于商家自调用时进行企业鉴权
        /// </summary>
        [XmlElement("merchant_enterprise_id")]
        public string MerchantEnterpriseId { get; set; }

        /// <summary>
        /// 服务商 ID，用于标识代商家调用的服务商。
        /// </summary>
        [XmlElement("service_provider_id")]
        public string ServiceProviderId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_product_price_list")]
        [XmlArrayItem("shop_product_price_list")]
        public List<ShopProductPriceList> ShopProductPriceList { get; set; }
    }
}
