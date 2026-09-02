using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryTreasurechestDataQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryTreasurechestDataQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("exchange_data_item_result")]
        public List<ExchangeDataItemResult> Items { get; set; }
    }
}
