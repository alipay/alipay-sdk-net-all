using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookingRule Data Structure.
    /// </summary>
    [Serializable]
    public class BookingRule : AopObject
    {
        /// <summary>
        /// 预订规则编号
        /// </summary>
        [XmlElement("booking_rule_id")]
        public string BookingRuleId { get; set; }

        /// <summary>
        /// 预定说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 报价生效的结束日期。 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 每天结束时间（次日使用+24小时的模式，例如次日3点，表示为27）
        /// </summary>
        [XmlElement("end_hour")]
        public string EndHour { get; set; }

        /// <summary>
        /// 最大提前预定时间（以用户选择的入住日期的23:59:59计算）
        /// </summary>
        [XmlElement("max_adv_hours")]
        public long MaxAdvHours { get; set; }

        /// <summary>
        /// 最大预定房间数量
        /// </summary>
        [XmlElement("max_amount")]
        public long MaxAmount { get; set; }

        /// <summary>
        /// 最多入住天数
        /// </summary>
        [XmlElement("max_days")]
        public long MaxDays { get; set; }

        /// <summary>
        /// 最少提前预定时间（以用户选择的入住日期的23:59:59计算）
        /// </summary>
        [XmlElement("min_adv_hours")]
        public long MinAdvHours { get; set; }

        /// <summary>
        /// 最少预定房间数量
        /// </summary>
        [XmlElement("min_amount")]
        public long MinAmount { get; set; }

        /// <summary>
        /// 最少入住天数
        /// </summary>
        [XmlElement("min_days")]
        public long MinDays { get; set; }

        /// <summary>
        /// 报价生效开始日期。当前日期不在日期段内则无法下单 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 每天开始时间（当前时间不在时间段内无法下单）
        /// </summary>
        [XmlElement("start_hour")]
        public string StartHour { get; set; }

        /// <summary>
        /// 有效星期。以逗号分割 0表示星期日， 1表示星期一， 剩余的以此类推。当天不在星期范围内则无法下单
        /// </summary>
        [XmlElement("week_set")]
        public string WeekSet { get; set; }
    }
}
