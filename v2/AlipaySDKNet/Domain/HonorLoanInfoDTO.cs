using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorLoanInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorLoanInfoDTO : AopObject
    {
        /// <summary>
        /// 年利率, 0.18 (年化)
        /// </summary>
        [XmlElement("apr")]
        public string Apr { get; set; }

        /// <summary>
        /// 支付宝绑卡id
        /// </summary>
        [XmlElement("bank_card_id")]
        public string BankCardId { get; set; }

        /// <summary>
        /// 借款优惠券id
        /// </summary>
        [XmlElement("coupon_no")]
        public string CouponNo { get; set; }

        /// <summary>
        /// 日利率,0.06 (年化/360*100) 保留6位数
        /// </summary>
        [XmlElement("day_rate")]
        public string DayRate { get; set; }

        /// <summary>
        /// 起息日期,格式yyyyMMdd
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 借款金额，单位：分
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 放款成功时间，时间戳毫秒
        /// </summary>
        [XmlElement("loan_time")]
        public long LoanTime { get; set; }

        /// <summary>
        /// 借款用途
        /// </summary>
        [XmlElement("loan_use")]
        public string LoanUse { get; set; }

        /// <summary>
        /// 还款方式，枚举值： 1-等额本息(灵活还)，2-等额本金(灵活还)，3-先息后本(灵活还)，4-等额本息(按期还)
        /// </summary>
        [XmlElement("repay_method")]
        public long RepayMethod { get; set; }

        /// <summary>
        /// 借款期数
        /// </summary>
        [XmlElement("total_term")]
        public long TotalTerm { get; set; }
    }
}
