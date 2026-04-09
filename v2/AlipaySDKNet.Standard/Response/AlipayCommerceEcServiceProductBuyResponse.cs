using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcServiceProductBuyResponse.
    /// </summary>
    public class AlipayCommerceEcServiceProductBuyResponse : AopResponse
    {
        /// <summary>
        /// 服务订购单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
