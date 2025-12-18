using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardShopstockSyncResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardShopstockSyncResponse : AopResponse
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
