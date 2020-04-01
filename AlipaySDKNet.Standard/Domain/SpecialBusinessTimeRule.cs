using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecialBusinessTimeRule Data Structure.
    /// </summary>
    [Serializable]
    public class SpecialBusinessTimeRule : AopObject
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 是否24小时不营业
        /// </summary>
        [XmlElement("close_all_day")]
        public bool CloseAllDay { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 是否24小时营业
        /// </summary>
        [XmlElement("open_all_day")]
        public bool OpenAllDay { get; set; }

        /// <summary>
        /// 当既不是24小时营业也不是24小时不营业时，具体的营业时间段
        /// </summary>
        [XmlArray("open_time_list")]
        [XmlArrayItem("time_range")]
        public List<TimeRange> OpenTimeList { get; set; }
    }
}
