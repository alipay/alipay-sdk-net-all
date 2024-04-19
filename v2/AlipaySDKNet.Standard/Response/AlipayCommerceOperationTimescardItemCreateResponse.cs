using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardItemCreateResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardItemCreateResponse : AopResponse
    {
        /// <summary>
        /// 次卡商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
