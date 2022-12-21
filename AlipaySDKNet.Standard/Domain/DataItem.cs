using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataItem Data Structure.
    /// </summary>
    [Serializable]
    public class DataItem : AopObject
    {
        /// <summary>
        /// 根据搜索请求参数ext_res_field返回的指定字段
        /// </summary>
        [XmlArray("ext_res_field")]
        [XmlArrayItem("string")]
        public List<string> ExtResField { get; set; }

        /// <summary>
        /// item的高亮的搜索摘要
        /// </summary>
        [XmlElement("highlight_summary")]
        public string HighlightSummary { get; set; }

        /// <summary>
        /// 带高亮的title
        /// </summary>
        [XmlElement("highlight_title")]
        public string HighlightTitle { get; set; }

        /// <summary>
        /// data的唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 图片列表
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 可搜索的商品总数
        /// </summary>
        [XmlElement("item_total_count")]
        public long ItemTotalCount { get; set; }

        /// <summary>
        /// item的打分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 搜索结果item的sequence用于关联搜索结果和用户行为
        /// </summary>
        [XmlElement("sequence")]
        public string Sequence { get; set; }

        /// <summary>
        /// item的搜索摘要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// item的title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 搜索结果item的trace_id用于关联搜索结果和用户行为
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
