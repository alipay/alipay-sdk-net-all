using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFRecordBase Data Structure.
    /// </summary>
    [Serializable]
    public class HDFRecordBase : AopObject
    {
        /// <summary>
        /// 单位厘米
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 测量时间
        /// </summary>
        [XmlElement("measure_time")]
        public string MeasureTime { get; set; }

        /// <summary>
        /// 单位 kg
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
