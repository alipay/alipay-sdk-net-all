using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApeitemQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApeitemQueryResponse : AopResponse
    {
        /// <summary>
        /// 可推荐的商品总数
        /// </summary>
        [XmlElement("item_total_count")]
        public long ItemTotalCount { get; set; }

        /// <summary>
        /// 推荐的item结果列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("ape_rec_item")]
        public List<ApeRecItem> Items { get; set; }

        /// <summary>
        /// 推荐请求的traceid，用于关联推荐结果和用户行为
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
