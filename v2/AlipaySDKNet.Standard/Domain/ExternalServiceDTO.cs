using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalServiceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalServiceDTO : AopObject
    {
        /// <summary>
        /// 租户服务介绍说明
        /// </summary>
        [XmlElement("service_introduce")]
        public string ServiceIntroduce { get; set; }

        /// <summary>
        /// 租户服务的关键词
        /// </summary>
        [XmlElement("service_key_words")]
        public string ServiceKeyWords { get; set; }

        /// <summary>
        /// 租户的服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
