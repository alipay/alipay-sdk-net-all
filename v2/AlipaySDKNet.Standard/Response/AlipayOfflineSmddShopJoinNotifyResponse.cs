using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddShopJoinNotifyResponse.
    /// </summary>
    public class AlipayOfflineSmddShopJoinNotifyResponse : AopResponse
    {
        /// <summary>
        /// 店铺id，进件通过后返回
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
