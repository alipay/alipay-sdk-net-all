using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationBusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationBusinessTime : AopObject
    {
        /// <summary>
        /// 关门时间，格式HH:mm
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 营业开门时间，格式HH:mm
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 表示周几的营业时间。1~6：表示周一到周六，7：表示周日
        /// </summary>
        [XmlElement("week_day")]
        public long WeekDay { get; set; }
    }
}
