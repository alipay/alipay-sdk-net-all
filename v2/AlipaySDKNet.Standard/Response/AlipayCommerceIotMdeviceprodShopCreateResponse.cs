using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodShopCreateResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 虚拟门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
