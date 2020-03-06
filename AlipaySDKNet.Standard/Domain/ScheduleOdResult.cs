using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleOdResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleOdResult : AopObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("schedule_od_item")]
        public List<ScheduleOdItem> Data { get; set; }

        /// <summary>
        /// 返回状态描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
