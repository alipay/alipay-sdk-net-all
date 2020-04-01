using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MetroOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class MetroOdItem : AopObject
    {
        /// <summary>
        /// D
        /// </summary>
        [XmlElement("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// 客流
        /// </summary>
        [XmlElement("od")]
        public long Od { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("user_info")]
        public CloudbusUserInfo UserInfo { get; set; }

        /// <summary>
        /// 周末客流
        /// </summary>
        [XmlElement("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日客流
        /// </summary>
        [XmlElement("work_od")]
        public long WorkOd { get; set; }
    }
}
