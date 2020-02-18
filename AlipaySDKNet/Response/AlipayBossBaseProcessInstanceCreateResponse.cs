using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCreateResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的实例
        /// </summary>
        [XmlElement("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
