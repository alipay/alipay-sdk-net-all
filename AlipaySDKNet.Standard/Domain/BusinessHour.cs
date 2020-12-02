using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessHour Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessHour : AopObject
    {
        /// <summary>
        /// 营业截止日期。使用星期值枚举 MON : 星期一;TUE : 星期二;WED : 星期三;THU : 星期四;FRI : 星期五;SAT : 星期六;SUN : 星期天
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 店铺营业时间段列表,示例:[{"start_date":"13:00","end_date":"14:00"},{"start_date":"17:00","end_date":"18:00"}]
        /// </summary>
        [XmlArray("hour_items")]
        [XmlArrayItem("business_hour_item")]
        public List<BusinessHourItem> HourItems { get; set; }

        /// <summary>
        /// 营业开始日期。使用星期值枚举 MON : 星期一;TUE : 星期二;WED : 星期三;THU : 星期四;FRI : 星期五;SAT : 星期六;SUN : 星期天
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
