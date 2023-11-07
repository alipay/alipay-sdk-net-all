using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudHoloinsightMicroappMetricQueryResponse.
    /// </summary>
    public class AlipayCloudHoloinsightMicroappMetricQueryResponse : AopResponse
    {
        /// <summary>
        /// 时序数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("holo_insight_data_query_result")]
        public List<HoloInsightDataQueryResult> Data { get; set; }
    }
}
