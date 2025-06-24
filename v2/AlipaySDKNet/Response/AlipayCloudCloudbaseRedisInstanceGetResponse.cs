using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseRedisInstanceGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseRedisInstanceGetResponse : AopResponse
    {
        /// <summary>
        /// 架构类型。集群版：分片集群架构，支持扩缩容、规格调整; 标准版：标准的 master-slave 架构，支持规格调整  - CLUSTER(集群版)  - STANDARD(标准版) - MINISPEC(极简版)
        /// </summary>
        [XmlElement("architecture_type")]
        public string ArchitectureType { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [XmlElement("instance_name")]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例规格，每个数据节点的内存大小  - 1GB  - 4GB -128MB
        /// </summary>
        [XmlElement("instance_spec")]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// 节点类型，仅集群版可用。单副本：数据节点中只有一个主数据节点，数据可靠性低；双副本：数据节点中具有主从两个数据节点，数据可靠性高  - SINGLE(单副本)  - DUPLICATES(双副本)
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 访问端口
        /// </summary>
        [XmlElement("proxy_port")]
        public string ProxyPort { get; set; }

        /// <summary>
        /// 访问域名
        /// </summary>
        [XmlElement("proxy_url")]
        public string ProxyUrl { get; set; }

        /// <summary>
        /// 代理节点Version
        /// </summary>
        [XmlElement("proxy_version")]
        public string ProxyVersion { get; set; }

        /// <summary>
        /// Redis版本  - 4.0
        /// </summary>
        [XmlElement("redis_version")]
        public string RedisVersion { get; set; }

        /// <summary>
        /// 区域  - cn-hangzhou
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 分片数，数据节点数量，仅集群版可用  - 1(分片)  - 2(分片)  - 4(分片)  - 8(分片)  - 16(分片)  - 32(分片)
        /// </summary>
        [XmlElement("shard_number")]
        public string ShardNumber { get; set; }

        /// <summary>
        /// 状态  - RUNNING(正常)  - CREATING(创建中)  - PAUSE(暂停)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 机房
        /// </summary>
        [XmlElement("zone")]
        public string Zone { get; set; }
    }
}
