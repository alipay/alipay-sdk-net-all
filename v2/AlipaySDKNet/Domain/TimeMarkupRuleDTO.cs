using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeMarkupRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TimeMarkupRuleDTO : AopObject
    {
        /// <summary>
        /// 时段加价规则的结束时间，格式为HH:MM
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 加价价格，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 时段加价规则开启时间，格式为HH:MM
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
