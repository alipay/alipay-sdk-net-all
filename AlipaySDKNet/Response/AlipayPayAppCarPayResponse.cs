using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppCarPayResponse.
    /// </summary>
    public class AlipayPayAppCarPayResponse : AopResponse
    {
        /// <summary>
        /// 上下文token
        /// </summary>
        [XmlElement("context_token")]
        public string ContextToken { get; set; }
    }
}
