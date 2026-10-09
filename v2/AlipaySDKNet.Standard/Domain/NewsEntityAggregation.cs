using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsEntityAggregation Data Structure.
    /// </summary>
    [Serializable]
    public class NewsEntityAggregation : AopObject
    {
        /// <summary>
        /// 企业名称聚合
        /// </summary>
        [XmlArray("cows")]
        [XmlArrayItem("news_aggregation_value")]
        public List<NewsAggregationValue> Cows { get; set; }

        /// <summary>
        /// 机构名称聚合
        /// </summary>
        [XmlArray("ogws")]
        [XmlArrayItem("news_aggregation_value")]
        public List<NewsAggregationValue> Ogws { get; set; }

        /// <summary>
        /// 人物名称聚合
        /// </summary>
        [XmlArray("ppws")]
        [XmlArrayItem("news_aggregation_value")]
        public List<NewsAggregationValue> Ppws { get; set; }
    }
}
