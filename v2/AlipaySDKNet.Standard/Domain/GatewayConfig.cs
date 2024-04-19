using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GatewayConfig Data Structure.
    /// </summary>
    [Serializable]
    public class GatewayConfig : AopObject
    {
        /// <summary>
        /// 网关域名
        /// </summary>
        [XmlElement("endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// 网关名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
