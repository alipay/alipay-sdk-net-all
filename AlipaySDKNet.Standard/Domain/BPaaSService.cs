using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BPaaSService Data Structure.
    /// </summary>
    [Serializable]
    public class BPaaSService : AopObject
    {
        /// <summary>
        /// 服务是否需要签约
        /// </summary>
        [XmlElement("if_sign")]
        public bool IfSign { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务ID
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

        /// <summary>
        /// 服务版本号
        /// </summary>
        [XmlElement("service_version")]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        [XmlElement("slogan")]
        public string Slogan { get; set; }
    }
}
