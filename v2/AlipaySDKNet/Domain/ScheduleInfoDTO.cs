using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleInfoDTO : AopObject
    {
        /// <summary>
        /// 时间段类型的调度的每天开始时间点
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 计划重复的方式信息
        /// </summary>
        [XmlElement("calendar_info")]
        public CalendarInfoDTO CalendarInfo { get; set; }

        /// <summary>
        /// 时间段类型的调度的每天结束时间点
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当需要设置相邻两次通知最小间隔时传入该字段，否则默认为60，最小值60，单位：分钟；当两次动账小于该时间时即使发生动账也不会发送通知
        /// </summary>
        [XmlElement("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// 每天触发的时间点
        /// </summary>
        [XmlElement("point_time")]
        public string PointTime { get; set; }

        /// <summary>
        /// 计划执行的时间，两种传参代表的含义如下： INTERVAL_TIME为在一段时间内满足条件触发动作； POINT_TIME为只在特定时间点触发动作
        /// </summary>
        [XmlElement("schedule_type")]
        public string ScheduleType { get; set; }
    }
}
