using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorServiceInfo : AopObject
    {
        /// <summary>
        /// 服务图标
        /// </summary>
        [XmlElement("service_icon")]
        public string ServiceIcon { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务开关，1: 可用，0:不可用
        /// </summary>
        [XmlElement("service_status")]
        public long ServiceStatus { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务链接
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
