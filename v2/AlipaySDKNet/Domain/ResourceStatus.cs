using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceStatus Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceStatus : AopObject
    {
        /// <summary>
        /// 资源实例ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [XmlElement("resource_type")]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源状态  - OPENING  - STARTED  - STOPPED  - RELEASE  - OPENING_FAIL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
