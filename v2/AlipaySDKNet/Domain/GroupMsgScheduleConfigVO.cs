using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgScheduleConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgScheduleConfigVO : AopObject
    {
        /// <summary>
        /// 用于描述定时发送的具体时间,  格式化为 HH:mm:ss
        /// </summary>
        [XmlElement("cron_time")]
        public string CronTime { get; set; }

        /// <summary>
        /// 用于描述周期消息定时发送的单位, 以周或者月为单位
        /// </summary>
        [XmlElement("cron_unit")]
        public string CronUnit { get; set; }

        /// <summary>
        /// 用于描述周期消息发送的具体的日期 当cron_unit=week, cron_value= "1"时, 表示每周一发送 当cron_unit=week, cron_value= "1,2,3,4,5,6,7"时, 表示每周一到周日发送 当cron_unit=month, cron_value= "1"时, 表示每月1号发送 当cron_unit=month, cron_value= "1,2,3"时, 表示每月1号2号3号发送
        /// </summary>
        [XmlElement("cron_value")]
        public string CronValue { get; set; }

        /// <summary>
        /// 用于描述群发消息周期发送的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于描述周期发送的开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
