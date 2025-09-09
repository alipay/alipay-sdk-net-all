using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyShopCreateResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回门店单标识
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }
    }
}
