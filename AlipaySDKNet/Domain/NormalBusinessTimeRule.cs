using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NormalBusinessTimeRule Data Structure.
    /// </summary>
    [Serializable]
    public class NormalBusinessTimeRule : AopObject
    {
        /// <summary>
        /// 指定月份,当为全年时，传入1,2,3,4,5,6,7,8,9,10,11,12
        /// </summary>
        [XmlArray("month")]
        [XmlArrayItem("number")]
        public List<long> Month { get; set; }

        /// <summary>
        /// 营业时间的时间段
        /// </summary>
        [XmlArray("open_time_list")]
        [XmlArrayItem("time_range")]
        public List<TimeRange> OpenTimeList { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        [XmlArray("week")]
        [XmlArrayItem("number")]
        public List<long> Week { get; set; }
    }
}
