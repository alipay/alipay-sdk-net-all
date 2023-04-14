using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBpaasServiceBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBpaasServiceBindModel : AopObject
    {
        /// <summary>
        /// bpaas应用id
        /// </summary>
        [XmlElement("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [XmlElement("bpaas_app_version")]
        public string BpaasAppVersion { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务版本
        /// </summary>
        [XmlElement("service_version")]
        public string ServiceVersion { get; set; }
    }
}
