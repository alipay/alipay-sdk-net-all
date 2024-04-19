using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwKnowledgeModifyResponse.
    /// </summary>
    public class AlipayIserviceCcmSwKnowledgeModifyResponse : AopResponse
    {
        /// <summary>
        /// 知识点ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
