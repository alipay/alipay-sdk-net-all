using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessHourItem Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessHourItem : AopObject
    {
        /// <summary>
        /// 营业结束时间，精确到分钟
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 营业开始时间，精确到分钟。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
