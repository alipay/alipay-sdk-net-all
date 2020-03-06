using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleTripResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleTripResult : AopObject
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
        [XmlArrayItem("schedule_trip_item")]
        public List<ScheduleTripItem> Data { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
