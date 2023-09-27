using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAittestOpenapiQueryResponse.
    /// </summary>
    public class AlipayOpenAittestOpenapiQueryResponse : AopResponse
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
