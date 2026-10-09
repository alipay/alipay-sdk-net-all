using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCustomerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCustomerQueryModel : AopObject
    {
        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }
    }
}
