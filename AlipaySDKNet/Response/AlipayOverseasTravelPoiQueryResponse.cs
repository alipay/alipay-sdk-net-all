using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelPoiQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelPoiQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝poi查询结果
        /// </summary>
        [XmlElement("poi_query_result")]
        public PoiQueryResult PoiQueryResult { get; set; }
    }
}
