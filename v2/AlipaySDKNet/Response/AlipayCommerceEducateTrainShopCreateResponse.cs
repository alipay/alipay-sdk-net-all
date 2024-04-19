using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainShopCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
