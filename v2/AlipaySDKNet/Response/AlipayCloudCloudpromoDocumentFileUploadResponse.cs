using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoDocumentFileUploadResponse.
    /// </summary>
    public class AlipayCloudCloudpromoDocumentFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 应用数据ID
        /// </summary>
        [XmlElement("document_id")]
        public string DocumentId { get; set; }
    }
}
