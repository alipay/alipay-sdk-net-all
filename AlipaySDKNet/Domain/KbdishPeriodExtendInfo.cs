using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishPeriodExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPeriodExtendInfo : AopObject
    {
        /// <summary>
        /// 结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 时间段规则
        /// </summary>
        [XmlArray("time_range_list")]
        [XmlArrayItem("kbdish_time_range_info")]
        public List<KbdishTimeRangeInfo> TimeRangeList { get; set; }

        /// <summary>
        /// 周规则(1-7数字，用逗号隔开)
        /// </summary>
        [XmlElement("weeks")]
        public string Weeks { get; set; }
    }
}
