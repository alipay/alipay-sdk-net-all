using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AosGoodItem Data Structure.
    /// </summary>
    [Serializable]
    public class AosGoodItem : AopObject
    {
        /// <summary>
        /// 业务链路ID
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

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
        /// 得分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// item的title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 搜索结果item的trace_id用于关联搜索结果和用户行为 当前字段已废弃(业务代码改造参数冲突)
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
