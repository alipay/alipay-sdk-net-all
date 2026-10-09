using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTaskProcessResponse.
    /// </summary>
    public class AlipayBossBaseProcessTaskProcessResponse : AopResponse
    {
        /// <summary>
        /// 流程实例数据
        /// </summary>
        [XmlElement("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
