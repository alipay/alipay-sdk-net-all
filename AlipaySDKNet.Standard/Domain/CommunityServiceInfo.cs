using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityServiceInfo : AopObject
    {
        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
