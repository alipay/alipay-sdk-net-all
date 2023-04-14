using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecGravityServiceHeader Data Structure.
    /// </summary>
    [Serializable]
    public class SecGravityServiceHeader : AopObject
    {
        /// <summary>
        /// 用于追踪异构系统间唯一服务调用的traceId
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
