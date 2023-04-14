using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDoc Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDoc : AopObject
    {
        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 风险docId
        /// </summary>
        [XmlElement("source_doc_id")]
        public string SourceDocId { get; set; }

        /// <summary>
        /// 风险docType
        /// </summary>
        [XmlElement("source_doc_type")]
        public string SourceDocType { get; set; }

        /// <summary>
        /// 风险摘要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 风险标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
