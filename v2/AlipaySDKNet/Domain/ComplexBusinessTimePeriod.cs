using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComplexBusinessTimePeriod Data Structure.
    /// </summary>
    [Serializable]
    public class ComplexBusinessTimePeriod : AopObject
    {
        /// <summary>
        /// 关门时间 格式：HH:mm
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 开门时间 格式：HH:mm
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }
    }
}
