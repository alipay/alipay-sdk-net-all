using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceShopBusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceShopBusinessTime : AopObject
    {
        /// <summary>
        /// 是否24小时营业
        /// </summary>
        [XmlElement("always_open")]
        public bool AlwaysOpen { get; set; }

        /// <summary>
        /// 营业结束时间 HH:mm 格式
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 营业开始时间 HH:mm 格式
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 每周第几天，逗号分割。如：周一、周三对应 1,3
        /// </summary>
        [XmlElement("week_days")]
        public string WeekDays { get; set; }
    }
}
