using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceAbility Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceAbility : AopObject
    {
        /// <summary>
        /// 服务能力名称
        /// </summary>
        [XmlElement("service_ability_key")]
        public string ServiceAbilityKey { get; set; }

        /// <summary>
        /// 服务能力配置值
        /// </summary>
        [XmlElement("service_ability_value")]
        public string ServiceAbilityValue { get; set; }
    }
}
