using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberRule Data Structure.
    /// </summary>
    [Serializable]
    public class MemberRule : AopObject
    {
        /// <summary>
        /// 指定周期模式适用。指定时间到期
        /// </summary>
        [XmlElement("appoint_date")]
        public string AppointDate { get; set; }

        /// <summary>
        /// 超时自动结算时间, 小于等于15
        /// </summary>
        [XmlElement("auto_settlement_time")]
        public string AutoSettlementTime { get; set; }

        /// <summary>
        /// 固定周期模式适用。 固定到期时间，存自然日，[1,28]。如填3号，当前2号，则到期时间为本月3号; 当前5号，到期时间为下月3号。
        /// </summary>
        [XmlElement("fix_date")]
        public string FixDate { get; set; }

        /// <summary>
        /// 冻结金额，周期扣需要传担保和储值金额，且冻结金额 = 担保金额 + 储值金额
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 拼团规则
        /// </summary>
        [XmlElement("groupon_rule")]
        public GrouponRule GrouponRule { get; set; }

        /// <summary>
        /// 周期扣担保金额部分
        /// </summary>
        [XmlElement("guarantee_amount")]
        public string GuaranteeAmount { get; set; }

        /// <summary>
        /// 会员周期，小于367
        /// </summary>
        [XmlElement("member_period")]
        public string MemberPeriod { get; set; }

        /// <summary>
        /// 承诺模式最低消费金额，承诺消费金额下不可空
        /// </summary>
        [XmlElement("min_consumer_amount")]
        public string MinConsumerAmount { get; set; }

        /// <summary>
        /// 承诺模式最低消费次数，承诺消费次数下不可空
        /// </summary>
        [XmlElement("min_consumer_times")]
        public string MinConsumerTimes { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// RELATIVE_DATE，相对日期，n*24模式； ABSOLATE_DATE，自然日模式（当日起计算）； ABSOLUTE_PLUS_1_DATE，自然日模式（当天不算）； FIX_DATE，每月固定日期到期[1,28]，自然月模式； APPOINT_DATE，指定时间到期;
        /// </summary>
        [XmlElement("period_mode")]
        public string PeriodMode { get; set; }

        /// <summary>
        /// 承诺模式必传。承诺条件。AMOUNT_SINGLE，金额满足条件。TIMES_SINGLE，次数满足条件。
        /// </summary>
        [XmlElement("promise_condition")]
        public string PromiseCondition { get; set; }

        /// <summary>
        /// 承诺模式必传。SINGLE，满足单一条件。
        /// </summary>
        [XmlElement("promise_type")]
        public string PromiseType { get; set; }

        /// <summary>
        /// 承诺会员文案，描述承诺任务
        /// </summary>
        [XmlElement("promise_type_desc")]
        public string PromiseTypeDesc { get; set; }

        /// <summary>
        /// 结算类型，承诺模式必传。 MEMBER_SETTLEMENT，按定价结算； BENEFIT_SETTLEMENT，按权益金额结算；
        /// </summary>
        [XmlElement("settlement_type")]
        public string SettlementType { get; set; }

        /// <summary>
        /// 周期扣储值金额部分
        /// </summary>
        [XmlElement("store_amount")]
        public string StoreAmount { get; set; }
    }
}
