using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinancialHolidayDayDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FinancialHolidayDayDTO : AopObject
    {
        /// <summary>
        /// 日
        /// </summary>
        [XmlElement("day")]
        public long Day { get; set; }

        /// <summary>
        /// 周
        /// </summary>
        [XmlElement("day_of_week")]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// 节假日'天'类型，全天，半天节假日
        /// </summary>
        [XmlElement("day_type")]
        public string DayType { get; set; }

        /// <summary>
        /// 节假日描述
        /// </summary>
        [XmlElement("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// 修改日期，时间戳格式
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 月
        /// </summary>
        [XmlElement("month")]
        public long Month { get; set; }

        /// <summary>
        /// 年
        /// </summary>
        [XmlElement("year")]
        public long Year { get; set; }
    }
}
