using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryCreateResponse : AopResponse
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
