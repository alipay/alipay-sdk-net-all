using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleTimeResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleTimeResult : AopObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("schedule_time_item")]
        public List<ScheduleTimeItem> Data { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
