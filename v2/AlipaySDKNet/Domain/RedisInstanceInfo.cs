using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RedisInstanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RedisInstanceInfo : AopObject
    {
        /// <summary>
        /// Redis实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// Redis实例名称
        /// </summary>
        [XmlElement("instance_name")]
        public string InstanceName { get; set; }
    }
}
