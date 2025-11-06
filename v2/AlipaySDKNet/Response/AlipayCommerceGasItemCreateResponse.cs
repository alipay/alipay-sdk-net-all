using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasItemCreateResponse.
    /// </summary>
    public class AlipayCommerceGasItemCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝加油系统商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
