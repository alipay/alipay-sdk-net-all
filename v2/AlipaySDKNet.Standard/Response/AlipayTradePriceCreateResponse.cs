using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePriceCreateResponse.
    /// </summary>
    public class AlipayTradePriceCreateResponse : AopResponse
    {
        /// <summary>
        /// 价格实例id
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 本次创建的商品或请求关联的商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
