using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcShopCreateResponse.
    /// </summary>
    public class AlipayCommerceEcShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 企业码门店id
        /// </summary>
        [XmlElement("ec_shop_id")]
        public string EcShopId { get; set; }
    }
}
