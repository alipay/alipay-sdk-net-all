using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 流程实例内容
        /// </summary>
        [XmlElement("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
