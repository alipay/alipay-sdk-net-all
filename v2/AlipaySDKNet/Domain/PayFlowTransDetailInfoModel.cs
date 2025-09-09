using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayFlowTransDetailInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class PayFlowTransDetailInfoModel : AopObject
    {
        /// <summary>
        /// 支付宝交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("alipay_total_amt")]
        public string AlipayTotalAmt { get; set; }

        /// <summary>
        /// 支付宝交易笔数（按月汇总）
        /// </summary>
        [XmlElement("alipay_total_cnt")]
        public string AlipayTotalCnt { get; set; }

        /// <summary>
        /// 交易天数（本月累计）
        /// </summary>
        [XmlElement("all_days")]
        public string AllDays { get; set; }

        /// <summary>
        /// 现金支付交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("cash_amt")]
        public string CashAmt { get; set; }

        /// <summary>
        /// 现金支付交易笔数（按月汇总）
        /// </summary>
        [XmlElement("cash_cnt")]
        public string CashCnt { get; set; }

        /// <summary>
        /// 信用卡(贷记卡) 交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("credit_card_amt")]
        public string CreditCardAmt { get; set; }

        /// <summary>
        /// 信用卡(贷记卡) 交易笔数（按月汇总）
        /// </summary>
        [XmlElement("credit_card_cnt")]
        public string CreditCardCnt { get; set; }

        /// <summary>
        /// 交易客户数
        /// </summary>
        [XmlElement("custom_num")]
        public string CustomNum { get; set; }

        /// <summary>
        /// 储蓄卡(借记银行卡) 交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("debit_card_amt")]
        public string DebitCardAmt { get; set; }

        /// <summary>
        /// 储蓄卡(借记银行卡) 交易笔数（按月汇总）
        /// </summary>
        [XmlElement("debit_card_cnt")]
        public string DebitCardCnt { get; set; }

        /// <summary>
        /// 失败交易总金额（月度，单位：元）
        /// </summary>
        [XmlElement("failed_amt")]
        public string FailedAmt { get; set; }

        /// <summary>
        /// 失败交易总笔数（月度）
        /// </summary>
        [XmlElement("failed_cnt")]
        public string FailedCnt { get; set; }

        /// <summary>
        /// 虚假交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("fraud_amt")]
        public string FraudAmt { get; set; }

        /// <summary>
        /// 虚假交易笔数（按月汇总）
        /// </summary>
        [XmlElement("fraud_cnt")]
        public string FraudCnt { get; set; }

        /// <summary>
        /// 高频消费客户消费总金额（单位：元）
        /// </summary>
        [XmlElement("high_amt")]
        public string HighAmt { get; set; }

        /// <summary>
        /// 高频消费客户消费总笔数
        /// </summary>
        [XmlElement("high_cnt")]
        public string HighCnt { get; set; }

        /// <summary>
        /// 高频消费客户数
        /// </summary>
        [XmlElement("high_frequency_custom")]
        public string HighFrequencyCustom { get; set; }

        /// <summary>
        /// 月度内单笔最大金额（单位：元）
        /// </summary>
        [XmlElement("max_amt")]
        public string MaxAmt { get; set; }

        /// <summary>
        /// 单日最大交易金额（单位：元）
        /// </summary>
        [XmlElement("max_day_amt")]
        public string MaxDayAmt { get; set; }

        /// <summary>
        /// 单日最大交易笔数
        /// </summary>
        [XmlElement("max_day_cnt")]
        public string MaxDayCnt { get; set; }

        /// <summary>
        /// 单笔最小交易金额（单位：元）
        /// </summary>
        [XmlElement("min_amt")]
        public string MinAmt { get; set; }

        /// <summary>
        /// 单日最小交易金额（单位：元）
        /// </summary>
        [XmlElement("min_day_amt")]
        public string MinDayAmt { get; set; }

        /// <summary>
        /// 单日最小交易笔数
        /// </summary>
        [XmlElement("min_day_cnt")]
        public string MinDayCnt { get; set; }

        /// <summary>
        /// 夜间交易金额（单位：元）
        /// </summary>
        [XmlElement("night_amt")]
        public string NightAmt { get; set; }

        /// <summary>
        /// 夜间交易笔数
        /// </summary>
        [XmlElement("night_cnt")]
        public string NightCnt { get; set; }

        /// <summary>
        /// 其他移动支付工具(非支付宝和微信)交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("other_amt")]
        public string OtherAmt { get; set; }

        /// <summary>
        /// 其他移动支付工具(非支付宝和微信)交易笔数（按月汇总）
        /// </summary>
        [XmlElement("other_cnt")]
        public string OtherCnt { get; set; }

        /// <summary>
        /// 90%分位交易金额（单位：元）
        /// </summary>
        [XmlElement("pct_90_ord_amt")]
        public string Pct90OrdAmt { get; set; }

        /// <summary>
        /// 95%分位交易金额（月度，单位：元）
        /// </summary>
        [XmlElement("pct_95_ord_amt")]
        public string Pct95OrdAmt { get; set; }

        /// <summary>
        /// 老客消费客户数
        /// </summary>
        [XmlElement("repeat_custom")]
        public string RepeatCustom { get; set; }

        /// <summary>
        /// 老客消费客户消费总金额（单位：元）
        /// </summary>
        [XmlElement("repeat_custom_amt")]
        public string RepeatCustomAmt { get; set; }

        /// <summary>
        /// 老客消费客户消费总笔数
        /// </summary>
        [XmlElement("repeat_custom_cnt")]
        public string RepeatCustomCnt { get; set; }

        /// <summary>
        /// 总交易金额（单位：元）
        /// </summary>
        [XmlElement("total_amt")]
        public string TotalAmt { get; set; }

        /// <summary>
        /// 总交易笔数
        /// </summary>
        [XmlElement("total_cnt")]
        public string TotalCnt { get; set; }

        /// <summary>
        /// 统计月份
        /// </summary>
        [XmlElement("vintage")]
        public string Vintage { get; set; }

        /// <summary>
        /// 凌晨交易金额（单位：元）
        /// </summary>
        [XmlElement("wee_hours_amt")]
        public string WeeHoursAmt { get; set; }

        /// <summary>
        /// 凌晨交易笔数
        /// </summary>
        [XmlElement("wee_hours_cnt")]
        public string WeeHoursCnt { get; set; }

        /// <summary>
        /// 周末交易金额（单位：元）
        /// </summary>
        [XmlElement("weekend_amt")]
        public string WeekendAmt { get; set; }

        /// <summary>
        /// 周末交易笔数
        /// </summary>
        [XmlElement("weekend_cnt")]
        public string WeekendCnt { get; set; }

        /// <summary>
        /// 微信支付交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("wx_total_amt")]
        public string WxTotalAmt { get; set; }

        /// <summary>
        /// 微信支付交易笔数（按月汇总）
        /// </summary>
        [XmlElement("wx_total_cnt")]
        public string WxTotalCnt { get; set; }
    }
}
