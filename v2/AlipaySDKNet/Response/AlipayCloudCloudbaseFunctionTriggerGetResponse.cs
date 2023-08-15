using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionTriggerGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionTriggerGetResponse : AopResponse
    {
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
        /// 触发器类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
