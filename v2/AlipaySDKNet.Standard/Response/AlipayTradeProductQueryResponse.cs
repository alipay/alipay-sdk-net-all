using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeProductQueryResponse.
    /// </summary>
    public class AlipayTradeProductQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("nexus_pay_product")]
        public List<NexusPayProduct> ProductList { get; set; }
    }
}
