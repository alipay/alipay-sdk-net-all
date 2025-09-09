using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalConfigmItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalConfigmItemDTO : AopObject
    {
        /// <summary>
        /// 配置项的名称
        /// </summary>
        [XmlElement("config_key")]
        public string ConfigKey { get; set; }

        /// <summary>
        /// 配置项对应的配置值
        /// </summary>
        [XmlElement("config_value")]
        public string ConfigValue { get; set; }
    }
}
