using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpusPublishTaskQueryParam Data Structure.
    /// </summary>
    [Serializable]
    public class CorpusPublishTaskQueryParam : AopObject
    {
        /// <summary>
        /// 知识语料类型
        /// </summary>
        [XmlElement("corpus_type")]
        public string CorpusType { get; set; }

        /// <summary>
        /// 发布类型
        /// </summary>
        [XmlElement("publish_type")]
        public string PublishType { get; set; }

        /// <summary>
        /// 发布任务的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
