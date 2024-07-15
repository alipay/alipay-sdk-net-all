using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceConfig : AopObject
    {
        /// <summary>
        /// 服务内容数据
        /// </summary>
        [XmlElement("service_content")]
        public string ServiceContent { get; set; }

        /// <summary>
        /// 服务的唯一标识
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
