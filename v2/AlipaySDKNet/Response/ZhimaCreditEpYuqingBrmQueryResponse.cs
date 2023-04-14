using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpYuqingBrmQueryResponse.
    /// </summary>
    public class ZhimaCreditEpYuqingBrmQueryResponse : AopResponse
    {
        /// <summary>
        /// 实体聚合结果
        /// </summary>
        [XmlElement("entity_aggregation")]
        public NewsEntityAggregation EntityAggregation { get; set; }

        /// <summary>
        /// 搜索结果
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("news_source")]
        public List<NewsSource> Hits { get; set; }

        /// <summary>
        /// 标签聚合结果
        /// </summary>
        [XmlArray("label_aggregation")]
        [XmlArrayItem("news_aggregation_value")]
        public List<NewsAggregationValue> LabelAggregation { get; set; }

        /// <summary>
        /// 搜索结果总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
