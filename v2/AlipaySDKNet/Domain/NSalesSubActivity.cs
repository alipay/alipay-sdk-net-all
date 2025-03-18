using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NSalesSubActivity Data Structure.
    /// </summary>
    [Serializable]
    public class NSalesSubActivity : AopObject
    {
        /// <summary>
        /// 卖进订单子活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 卖进订单子活动履约金额
        /// </summary>
        [XmlElement("fulfill_amount")]
        public string FulfillAmount { get; set; }

        /// <summary>
        /// 卖进订单子活动履约状态，初始化或进行中的子任务不会返回该字段。
        /// </summary>
        [XmlElement("fulfill_status")]
        public string FulfillStatus { get; set; }

        /// <summary>
        /// 卖进订单子活动期号
        /// </summary>
        [XmlElement("period_no")]
        public long PeriodNo { get; set; }

        /// <summary>
        /// 当期子活动支付宝记录参考收单笔数，未开启统计前不会返回该字段。
        /// </summary>
        [XmlElement("refer_trade_count")]
        public long ReferTradeCount { get; set; }

        /// <summary>
        /// 当期子活动支付宝记录参考收单天数，未开启统计前不会返回该字段。
        /// </summary>
        [XmlElement("refer_trade_days")]
        public long ReferTradeDays { get; set; }

        /// <summary>
        /// 卖进订单子活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 卖进订单子活动id
        /// </summary>
        [XmlElement("sub_activity_id")]
        public string SubActivityId { get; set; }

        /// <summary>
        /// 卖进订单子活动状态
        /// </summary>
        [XmlElement("sub_activity_status")]
        public string SubActivityStatus { get; set; }

        /// <summary>
        /// 当期子活动目标收单笔数
        /// </summary>
        [XmlElement("target_trade_count")]
        public long TargetTradeCount { get; set; }

        /// <summary>
        /// 当期子活动目标收单天数
        /// </summary>
        [XmlElement("target_trade_days")]
        public long TargetTradeDays { get; set; }
    }
}
