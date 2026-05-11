using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AcquirePayFlowTransDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AcquirePayFlowTransDetailInfo : AopObject
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
        /// 储蓄卡(借记银行卡) 交易金额（按月汇总，单位：元）
        /// </summary>
        [XmlElement("debit_card_amt")]
        public string DebitCardAmt { get; set; }

        /// <summary>
        /// 储蓄卡(借记银行卡) 交易笔数（按月汇总)
        /// </summary>
        [XmlElement("debit_card_cnt")]
        public string DebitCardCnt { get; set; }

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
