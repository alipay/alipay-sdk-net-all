using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseMonitorAlarmruleCreateModel : AopObject
    {
        /// <summary>
        /// 报警级别
        /// </summary>
        [XmlElement("alarm_level")]
        public string AlarmLevel { get; set; }

        /// <summary>
        /// 小程序云app ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 报警名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否启用报警规则
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 报警生效时间配置
        /// </summary>
        [XmlElement("time_config")]
        public AlarmTimeConfig TimeConfig { get; set; }

        /// <summary>
        /// 多个告警规则的触发条件
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
