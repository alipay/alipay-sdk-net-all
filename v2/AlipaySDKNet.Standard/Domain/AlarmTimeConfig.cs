using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmTimeConfig Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmTimeConfig : AopObject
    {
        /// <summary>
        /// 生效开始时间(格式：HH:mm:dd)
        /// </summary>
        [XmlElement("from")]
        public string From { get; set; }

        /// <summary>
        /// 时间类型  - BY_DAY  - BY_WEEK
        /// </summary>
        [XmlElement("time_type")]
        public string TimeType { get; set; }

        /// <summary>
        /// 生效结束时间(格式：HH:mm:dd)
        /// </summary>
        [XmlElement("to")]
        public string To { get; set; }

        /// <summary>
        /// 每周几触发
        /// </summary>
        [XmlArray("weeks")]
        [XmlArrayItem("number")]
        public List<long> Weeks { get; set; }
    }
}
