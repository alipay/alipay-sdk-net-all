using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniResourceCreateResponse.
    /// </summary>
    public class AlipayOpenMiniResourceCreateResponse : AopResponse
    {
        /// <summary>
        /// 流量位id
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
