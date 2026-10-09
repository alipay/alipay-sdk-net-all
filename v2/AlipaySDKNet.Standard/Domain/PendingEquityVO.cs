using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PendingEquityVO Data Structure.
    /// </summary>
    [Serializable]
    public class PendingEquityVO : AopObject
    {
        /// <summary>
        /// 预算类型
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 海豚活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 主单据号
        /// </summary>
        [XmlElement("camp_order_id")]
        public string CampOrderId { get; set; }

        /// <summary>
        /// 发奖渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 展示信息
        /// </summary>
        [XmlElement("display_info")]
        public string DisplayInfo { get; set; }

        /// <summary>
        /// 证券营销活动id
        /// </summary>
        [XmlElement("interest_id")]
        public string InterestId { get; set; }

        /// <summary>
        /// 奖励金额, 以分为单位
        /// </summary>
        [XmlElement("prize_amount")]
        public string PrizeAmount { get; set; }

        /// <summary>
        /// 具体奖励类型
        /// </summary>
        [XmlElement("prize_biz_type")]
        public string PrizeBizType { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品定价策略
        /// </summary>
        [XmlElement("prize_strategy_type")]
        public string PrizeStrategyType { get; set; }

        /// <summary>
        /// 发奖单据号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }
    }
}
