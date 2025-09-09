using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotionDurationResponse Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionDurationResponse : AopObject
    {
        /// <summary>
        /// 时段列表，如：01:00:00-02:00:00，代表1点到2点
        /// </summary>
        [XmlArray("hour_list")]
        [XmlArrayItem("string")]
        public List<string> HourList { get; set; }

        /// <summary>
        /// 周时间列表，如：["1","2"]，代表周一、周二
        /// </summary>
        [XmlArray("week_list")]
        [XmlArrayItem("string")]
        public List<string> WeekList { get; set; }
    }
}
