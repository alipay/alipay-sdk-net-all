using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeSingletripdurationQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeSingletripdurationQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 查询结果集合
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("single_trip_duration_query_openapi_result")]
        public List<SingleTripDurationQueryOpenapiResult> Result { get; set; }
    }
}
