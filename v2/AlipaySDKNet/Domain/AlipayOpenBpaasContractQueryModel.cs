using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBpaasContractQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBpaasContractQueryModel : AopObject
    {
        /// <summary>
        /// bpaas 应用ID
        /// </summary>
        [XmlElement("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// bpaas服务ID；注意：同一个服务不同版本ID不同
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
