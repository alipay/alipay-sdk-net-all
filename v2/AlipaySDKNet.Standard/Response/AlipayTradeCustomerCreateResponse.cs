using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCustomerCreateResponse.
    /// </summary>
    public class AlipayTradeCustomerCreateResponse : AopResponse
    {
        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }
    }
}
