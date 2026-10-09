using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCustomerModifyResponse.
    /// </summary>
    public class AlipayTradeCustomerModifyResponse : AopResponse
    {
        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }
    }
}
