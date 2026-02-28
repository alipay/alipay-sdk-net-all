using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopSyncResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceShopSyncResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
