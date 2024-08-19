using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenapiServerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenapiServerDTO : AopObject
    {
        /// <summary>
        /// 逻辑zone
        /// </summary>
        [XmlElement("cell")]
        public string Cell { get; set; }

        /// <summary>
        /// 服务实例名, 有状态服务将会固定该实例名称，在重建或者故障迁移后，依然能保持服务实例名不变
        /// </summary>
        [XmlElement("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// 实例的IP地址
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [XmlElement("pod_name")]
        public string PodName { get; set; }

        /// <summary>
        /// 实例序号
        /// </summary>
        [XmlElement("pod_no")]
        public string PodNo { get; set; }

        /// <summary>
        /// 实例全局唯一id
        /// </summary>
        [XmlElement("pod_uuid")]
        public string PodUuid { get; set; }

        /// <summary>
        /// 实例部署版本
        /// </summary>
        [XmlElement("pod_version")]
        public string PodVersion { get; set; }

        /// <summary>
        /// 重建原因和方式
        /// </summary>
        [XmlElement("recreate_info")]
        public RecreateStatus RecreateInfo { get; set; }

        /// <summary>
        /// 发布部署状态
        /// </summary>
        [XmlElement("release_status")]
        public string ReleaseStatus { get; set; }

        /// <summary>
        /// 服务状态，常用值Running、Pending、Terminating、Available等
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 实例最新状态更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 实例详细状态信息
        /// </summary>
        [XmlElement("upgrade_progress")]
        public string UpgradeProgress { get; set; }
    }
}
