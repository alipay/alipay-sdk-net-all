using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceCreateCustomerResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceCreateCustomerResponse : AopObject
    {
        /// <summary>
        /// 客户bid
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
