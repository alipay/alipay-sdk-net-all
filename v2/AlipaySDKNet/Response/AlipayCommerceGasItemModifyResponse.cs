using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasItemModifyResponse.
    /// </summary>
    public class AlipayCommerceGasItemModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
