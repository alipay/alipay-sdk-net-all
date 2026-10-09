using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcShopProductpriceModifyResponse.
    /// </summary>
    public class AlipayCommerceEcShopProductpriceModifyResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("shop_product_price_modify_result")]
        public List<ShopProductPriceModifyResult> FailList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("success_list")]
        [XmlArrayItem("shop_product_price_modify_result")]
        public List<ShopProductPriceModifyResult> SuccessList { get; set; }
    }
}
