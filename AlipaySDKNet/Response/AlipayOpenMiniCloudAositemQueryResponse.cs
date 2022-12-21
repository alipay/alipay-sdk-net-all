using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudAositemQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCloudAositemQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回请求参数中对应aggregation_field指定要聚合的字段的值
        /// </summary>
        [XmlElement("aggregation_result")]
        public string AggregationResult { get; set; }

        /// <summary>
        /// 结果总量
        /// </summary>
        [XmlElement("item_total_count")]
        public long ItemTotalCount { get; set; }

        /// <summary>
        /// 搜索的item结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("data_item")]
        public List<DataItem> Result { get; set; }

        /// <summary>
        /// 搜索请求的traceid，用于排查问题及关联s搜索结果和用户行为
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
