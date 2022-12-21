using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudAossuggestQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCloudAossuggestQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果的总条数
        /// </summary>
        [XmlElement("item_total_count")]
        public string ItemTotalCount { get; set; }

        /// <summary>
        /// 搜索suggest数据
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("aos_suggest_item")]
        public List<AosSuggestItem> Result { get; set; }

        /// <summary>
        /// 请求的traceid，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
