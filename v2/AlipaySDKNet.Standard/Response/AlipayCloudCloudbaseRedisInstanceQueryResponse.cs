using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseRedisInstanceQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseRedisInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 实例列表
        /// </summary>
        [XmlArray("instances")]
        [XmlArrayItem("redis_instance_info")]
        public List<RedisInstanceInfo> Instances { get; set; }
    }
}
