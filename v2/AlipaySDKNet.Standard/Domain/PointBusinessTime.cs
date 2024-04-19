using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PointBusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class PointBusinessTime : AopObject
    {
        /// <summary>
        /// 关门时间 格式HH:mm
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 开门时间 HH:mm
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 1-7表示星期一到星期日
        /// </summary>
        [XmlElement("week_day")]
        public long WeekDay { get; set; }
    }
}
