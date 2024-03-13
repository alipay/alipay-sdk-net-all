using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchAgentframeworkWarrenqQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchAgentframeworkWarrenqQueryResponse : AopResponse
    {
        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
