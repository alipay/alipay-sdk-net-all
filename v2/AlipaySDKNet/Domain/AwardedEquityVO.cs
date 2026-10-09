using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AwardedEquityVO Data Structure.
    /// </summary>
    [Serializable]
    public class AwardedEquityVO : AopObject
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
        /// 是否是存量权益
        /// </summary>
        [XmlElement("exists_equity")]
        public bool ExistsEquity { get; set; }

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
        /// 券创建时间
        /// </summary>
        [XmlElement("voucher_gmt_create")]
        public string VoucherGmtCreate { get; set; }

        /// <summary>
        /// 券过期时间
        /// </summary>
        [XmlElement("voucher_gmt_expired")]
        public string VoucherGmtExpired { get; set; }

        /// <summary>
        /// 券变更时间
        /// </summary>
        [XmlElement("voucher_gmt_modified")]
        public string VoucherGmtModified { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }
    }
}
