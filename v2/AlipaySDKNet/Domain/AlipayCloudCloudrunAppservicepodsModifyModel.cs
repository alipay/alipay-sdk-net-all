using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunAppservicepodsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunAppservicepodsModifyModel : AopObject
    {
        /// <summary>
        /// 应用服务名
        /// </summary>
        [XmlElement("app_service_name")]
        public string AppServiceName { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 主机实例名
        /// </summary>
        [XmlElement("host_name")]
        public string HostName { get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [XmlElement("pod_name")]
        public string PodName { get; set; }

        /// <summary>
        /// 实例全局唯一id
        /// </summary>
        [XmlElement("pod_uuid")]
        public string PodUuid { get; set; }
    }
}
