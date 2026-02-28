using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopstockSyncResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceShopstockSyncResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
