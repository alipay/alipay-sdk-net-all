using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwArticleCreateResponse : AopResponse
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
