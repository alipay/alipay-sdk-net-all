using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NPromoSubActivity Data Structure.
    /// </summary>
    [Serializable]
    public class NPromoSubActivity : AopObject
    {
        /// <summary>
        /// 当期任务正常可推进时间，具体到小时。
        /// </summary>
        [XmlElement("advanceable_time")]
        public string AdvanceableTime { get; set; }

        /// <summary>
        /// 当期活动的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户活动期号
        /// </summary>
        [XmlElement("period_no")]
        public long PeriodNo { get; set; }

        /// <summary>
        /// 当期活动的开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子活动状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户单期子活动的id
        /// </summary>
        [XmlElement("sub_activity_id")]
        public string SubActivityId { get; set; }

        /// <summary>
        /// 完成当期活动需要的收单笔数
        /// </summary>
        [XmlElement("target_trade_counts")]
        public long TargetTradeCounts { get; set; }

        /// <summary>
        /// 完成当期活动需要的收单天数
        /// </summary>
        [XmlElement("target_trade_days")]
        public long TargetTradeDays { get; set; }
    }
}
