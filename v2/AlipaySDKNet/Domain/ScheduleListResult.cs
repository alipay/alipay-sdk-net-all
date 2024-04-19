using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleListResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleListResult : AopObject
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
        [XmlArrayItem("schedule_list_item")]
        public List<ScheduleListItem> Data { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
