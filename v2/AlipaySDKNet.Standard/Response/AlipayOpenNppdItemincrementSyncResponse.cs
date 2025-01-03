using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenNppdItemincrementSyncResponse.
    /// </summary>
    public class AlipayOpenNppdItemincrementSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
