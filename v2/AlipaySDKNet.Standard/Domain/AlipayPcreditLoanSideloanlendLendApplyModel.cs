using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendLendApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloanlendLendApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 客户指定放款卡场景使用，绑卡唯一id
        /// </summary>
        [XmlElement("bank_card_id")]
        public string BankCardId { get; set; }

        /// <summary>
        /// 营销卡券Code列表,不能超过100个
        /// </summary>
        [XmlArray("coupon_code_list")]
        [XmlArrayItem("string")]
        public List<string> CouponCodeList { get; set; }

        /// <summary>
        /// 渠道侧授信申请单号
        /// </summary>
        [XmlElement("credit_apply_no")]
        public string CreditApplyNo { get; set; }

        /// <summary>
        /// 扩展字段JSON String
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 贷款金额（单位：元）保留小数点后两位
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 阿里贷款申请编号，唯一单号，幂等键，长度32
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 以阿里侧贷款用途为准
        /// </summary>
        [XmlElement("loan_purpose")]
        public string LoanPurpose { get; set; }

        /// <summary>
        /// 贷款期限 6/11/12
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位 MONTH -- "月" DAY -- "日" TERM -- “期”
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 支用类型
        /// </summary>
        [XmlElement("loan_type")]
        public string LoanType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁借贷款产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠利息，单位元，保留2位小数
        /// </summary>
        [XmlElement("promotion_amount")]
        public string PromotionAmount { get; set; }

        /// <summary>
        /// 固定还款日
        /// </summary>
        [XmlElement("repayment_day")]
        public long RepaymentDay { get; set; }

        /// <summary>
        /// 还款方式，枚举值 AVERAGE_CAPITAL_PLUS_INTEREST等额本息 AVERAGE_CAPITAL等额本金 BALLOON_MORTGAGE按期付息到期还本 REPAY_OUTRIGHT一次性到期还本付息
        /// </summary>
        [XmlElement("repayment_method")]
        public string RepaymentMethod { get; set; }

        /// <summary>
        /// 待补充
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
