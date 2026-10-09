using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsAggregationValue Data Structure.
    /// </summary>
    [Serializable]
    public class NewsAggregationValue : AopObject
    {
        /// <summary>
        /// 聚合结果数量
        /// </summary>
        [XmlElement("doc_count")]
        public string DocCount { get; set; }

        /// <summary>
        /// 聚合结果名称
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
