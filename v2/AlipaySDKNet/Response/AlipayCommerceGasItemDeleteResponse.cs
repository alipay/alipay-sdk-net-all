using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasItemDeleteResponse.
    /// </summary>
    public class AlipayCommerceGasItemDeleteResponse : AopResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
