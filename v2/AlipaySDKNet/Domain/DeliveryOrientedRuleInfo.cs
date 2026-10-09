using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryOrientedRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryOrientedRuleInfo : AopObject
    {
        /// <summary>
        /// 客户端
        /// </summary>
        [XmlElement("client_platform")]
        public string ClientPlatform { get; set; }
    }
}
