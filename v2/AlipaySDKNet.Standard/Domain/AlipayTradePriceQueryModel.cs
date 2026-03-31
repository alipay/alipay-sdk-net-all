using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradePriceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePriceQueryModel : AopObject
    {
        /// <summary>
        /// 价格id
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }
    }
}
