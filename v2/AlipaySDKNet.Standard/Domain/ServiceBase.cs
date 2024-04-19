using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceBase Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceBase : AopObject
    {
        /// <summary>
        /// 服务载体链接
        /// </summary>
        [XmlElement("service_carrier_url")]
        public string ServiceCarrierUrl { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务Logo
        /// </summary>
        [XmlElement("service_logo")]
        public string ServiceLogo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务简述
        /// </summary>
        [XmlElement("service_simple_desc")]
        public string ServiceSimpleDesc { get; set; }

        /// <summary>
        /// 服务规格
        /// </summary>
        [XmlElement("service_spec_code")]
        public string ServiceSpecCode { get; set; }
    }
}
