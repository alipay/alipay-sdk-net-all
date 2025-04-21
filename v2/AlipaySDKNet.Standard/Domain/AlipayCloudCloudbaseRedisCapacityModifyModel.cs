using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseRedisCapacityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseRedisCapacityModifyModel : AopObject
    {
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
        /// 实例规格，单位为1GB、4GB、8GB、16GB、128M
        /// </summary>
        [XmlElement("instance_spec")]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 分片数，数据节点数量，仅集群版可用 - 1(分片) - 2(分片) - 4(分片) - 8(分片) - 16(分片) - 32(分片)
        /// </summary>
        [XmlElement("shard_number")]
        public string ShardNumber { get; set; }

        /// <summary>
        /// 机房
        /// </summary>
        [XmlElement("zone")]
        public string Zone { get; set; }
    }
}
