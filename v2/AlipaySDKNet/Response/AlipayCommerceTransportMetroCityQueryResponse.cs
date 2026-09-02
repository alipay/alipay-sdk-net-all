using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportMetroCityQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportMetroCityQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("query_city_resp")]
        public List<QueryCityResp> List { get; set; }
    }
}
