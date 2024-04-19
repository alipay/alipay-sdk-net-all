using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppServiceResult Data Structure.
    /// </summary>
    [Serializable]
    public class AppServiceResult : AopObject
    {
        /// <summary>
        /// 跳转地址
        /// </summary>
        [XmlElement("carrier_url")]
        public string CarrierUrl { get; set; }

        /// <summary>
        /// 子服务的logo地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 简要描述
        /// </summary>
        [XmlElement("simple_desc")]
        public string SimpleDesc { get; set; }
    }
}
