using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleShiftResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleShiftResult : AopObject
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
        [XmlArrayItem("schedule_shift_item")]
        public List<ScheduleShiftItem> Data { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
