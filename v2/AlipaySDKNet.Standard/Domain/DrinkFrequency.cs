using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrinkFrequency Data Structure.
    /// </summary>
    [Serializable]
    public class DrinkFrequency : AopObject
    {
        /// <summary>
        /// 次
        /// </summary>
        [XmlElement("frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 单位周
        /// </summary>
        [XmlElement("time_unit")]
        public string TimeUnit { get; set; }
    }
}
