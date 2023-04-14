using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceProductAbilityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceProductAbilityInfo : AopObject
    {
        /// <summary>
        /// 服务能力id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 服务能力
        /// </summary>
        [XmlElement("service_ability")]
        public string ServiceAbility { get; set; }

        /// <summary>
        /// 服务能力名字
        /// </summary>
        [XmlElement("service_ability_name")]
        public string ServiceAbilityName { get; set; }

        /// <summary>
        /// 服务产品id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
