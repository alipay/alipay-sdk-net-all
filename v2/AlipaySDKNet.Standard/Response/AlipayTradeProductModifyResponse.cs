using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeProductModifyResponse.
    /// </summary>
    public class AlipayTradeProductModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
