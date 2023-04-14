using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EndTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EndTimeInfo : AopObject
    {
        /// <summary>
        /// 结束时间  格式：HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间类型
        /// </summary>
        [XmlElement("end_time_type")]
        public string EndTimeType { get; set; }
    }
}
