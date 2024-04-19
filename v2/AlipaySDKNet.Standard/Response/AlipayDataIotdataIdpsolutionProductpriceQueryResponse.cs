using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataIdpsolutionProductpriceQueryResponse.
    /// </summary>
    public class AlipayDataIotdataIdpsolutionProductpriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 推荐价格列表，is_suggest_price：1推荐，0不推荐；price：推荐的价格，单位：分；freq：权重
        /// </summary>
        [XmlArray("price_dist")]
        [XmlArrayItem("recommend_price")]
        public List<RecommendPrice> PriceDist { get; set; }

        /// <summary>
        /// 单位：分
        /// </summary>
        [XmlElement("suggest_price")]
        public long SuggestPrice { get; set; }
    }
}
