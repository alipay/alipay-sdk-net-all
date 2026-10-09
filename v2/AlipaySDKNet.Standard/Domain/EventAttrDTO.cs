using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EventAttrDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EventAttrDTO : AopObject
    {
        /// <summary>
        /// 配置名称: 1.监控持续时间（单位：分钟）：MONITOR_DURATION 2.统计次数（单位：次）：STATISTICS_COUNT 两种配置必须同时出现
        /// </summary>
        [XmlElement("config_key")]
        public string ConfigKey { get; set; }

        /// <summary>
        /// 配置值： MONITOR_DURATION：建议值:1-60的整数值，单位为分钟。 STATISTICS_COUNT:大于0的整数。
        /// </summary>
        [XmlElement("config_value")]
        public string ConfigValue { get; set; }
    }
}
