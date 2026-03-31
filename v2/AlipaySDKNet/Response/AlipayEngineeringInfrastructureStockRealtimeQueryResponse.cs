using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEngineeringInfrastructureStockRealtimeQueryResponse.
    /// </summary>
    public class AlipayEngineeringInfrastructureStockRealtimeQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("trend_data_d_t_o")]
        public List<TrendDataDTO> Data { get; set; }
    }
}
