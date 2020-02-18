using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportOilproductInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOilproductInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 油站列表
        /// </summary>
        [XmlElement("oil_station_models")]
        public OilStationDetails OilStationModels { get; set; }
    }
}
