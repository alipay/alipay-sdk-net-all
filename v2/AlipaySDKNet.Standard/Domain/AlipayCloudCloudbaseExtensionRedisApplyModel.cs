using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionRedisApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseExtensionRedisApplyModel : AopObject
    {
        /// <summary>
        /// 架构类型。集群版：分片集群架构，支持扩缩容、规格调整; 标准版：标准的 master-slave 架构，支持规格调整  - CLUSTER(集群版)  - STANDARD(标准版)
        /// </summary>
        [XmlElement("architecture_type")]
        public string ArchitectureType { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [XmlElement("instance_name")]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例规格，每个数据节点的内存大小  - 1GB  - 4GB
        /// </summary>
        [XmlElement("instance_spec")]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// 节点类型，仅集群版可用。单副本：数据节点中只有一个主数据节点，数据可靠性低；双副本：数据节点中具有主从两个数据节点，数据可靠性高  - SINGLE(单副本)  - DUPLICATES(双副本)
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }

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
    }
}
