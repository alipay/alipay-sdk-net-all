using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionTriggerSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionTriggerSetModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 定时触发器列表
        /// </summary>
        [XmlArray("schedules")]
        [XmlArrayItem("schedule")]
        public List<Schedule> Schedules { get; set; }

        /// <summary>
        /// 触发器名称
        /// </summary>
        [XmlElement("trigger_name")]
        public string TriggerName { get; set; }

        /// <summary>
        /// 触发器类型  - SCHEDULE
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
