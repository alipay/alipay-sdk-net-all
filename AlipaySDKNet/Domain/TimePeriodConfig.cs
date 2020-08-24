using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimePeriodConfig Data Structure.
    /// </summary>
    [Serializable]
    public class TimePeriodConfig : AopObject
    {
        /// <summary>
        /// 自提时段列表，包含时段开始时间和结束时间
        /// </summary>
        [XmlArray("time_period_list")]
        [XmlArrayItem("time_period")]
        public List<TimePeriod> TimePeriodList { get; set; }

        /// <summary>
        /// 1-7分别表示周一到周日
        /// </summary>
        [XmlElement("week")]
        public string Week { get; set; }
    }
}
