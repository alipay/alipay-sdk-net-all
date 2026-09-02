using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAiKnowledgeDocumentModifyResponse.
    /// </summary>
    public class AlipayOpenAiKnowledgeDocumentModifyResponse : AopResponse
    {
        /// <summary>
        /// 文档上传后的资源id
        /// </summary>
        [XmlElement("data_source_id")]
        public string DataSourceId { get; set; }

        /// <summary>
        /// 文档id
        /// </summary>
        [XmlElement("document_id")]
        public string DocumentId { get; set; }

        /// <summary>
        /// ACCEPTED：已受理
        /// </summary>
        [XmlElement("submit_status")]
        public string SubmitStatus { get; set; }
    }
}
