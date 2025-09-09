using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DocumentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DocumentInfo : AopObject
    {
        /// <summary>
        /// RAG中所引用知识库文档的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// RAG中所引用知识库文档的url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
