using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeConfig Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeConfig : AopObject
    {
        /// <summary>
        /// 总预算,目前仅支持个数预算
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// COUNT 数量预算 AMOUNT 金额预算
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 计次配置
        /// </summary>
        [XmlArray("count_control_config")]
        [XmlArrayItem("count_control_config")]
        public List<CountControlConfig> CountControlConfig { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_properties")]
        public string ExtProperties { get; set; }

        /// <summary>
        /// 奖品开始时间
        /// </summary>
        [XmlElement("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 奖品结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 域账号或者商家pid
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// PLATFORM标识平台，MERCHANT标识商户
        /// </summary>
        [XmlElement("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品定价配置，目前只支持定额奖品
        /// </summary>
        [XmlElement("prize_price_strategy")]
        public PrizePriceStrategy PrizePriceStrategy { get; set; }

        /// <summary>
        /// 奖品类型,每一种值对应一种奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 剩余预算,目前仅支持个数预算
        /// </summary>
        [XmlElement("remain_amount")]
        public string RemainAmount { get; set; }

        /// <summary>
        /// PRIZE_CREATED("PRIZE_CREATED", "已创建状态") PRIZE_OPENED("PRIZE_OPENED", "开启状态") PRIZE_PAUSED("PRIZE_PAUSED", "暂停状态") PRIZE_CLOSED("PRIZE_CLOSED", "关闭状态")
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 使用有效期
        /// </summary>
        [XmlElement("valid_period")]
        public PrizeValidPeriod ValidPeriod { get; set; }
    }
}
