using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmRule Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmRule : AopObject
    {
        /// <summary>
        /// 报警级别  - EMERGENCY(紧急)  - CRITICAL(严重)  - HIGH(高)  - MEDIUM(中)  - LOW(低)
        /// </summary>
        [XmlElement("alarm_level")]
        public string AlarmLevel { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 报警规则名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 报警生效时间配置
        /// </summary>
        [XmlElement("time_config")]
        public AlarmTimeConfig TimeConfig { get; set; }

        /// <summary>
        /// 报警触发条件  - OR(满足任意条件)  - AND(满足所有条件)
        /// </summary>
        [XmlElement("trigger_condition")]
        public string TriggerCondition { get; set; }

        /// <summary>
        /// 报警触发条件集合
        /// </summary>
        [XmlArray("triggers")]
        [XmlArrayItem("alarm_trigger")]
        public List<AlarmTrigger> Triggers { get; set; }
    }
}
