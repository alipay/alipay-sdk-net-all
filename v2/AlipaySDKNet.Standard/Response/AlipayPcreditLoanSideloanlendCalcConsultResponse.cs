using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendCalcConsultResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanlendCalcConsultResponse : AopResponse
    {
        /// <summary>
        /// 试算是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 本次试算使用的营销卡券列表
        /// </summary>
        [XmlArray("coupon_code_list")]
        [XmlArrayItem("string")]
        public List<string> CouponCodeList { get; set; }

        /// <summary>
        /// 授信总额度，单位元，保留两位小数
        /// </summary>
        [XmlElement("credit_quota")]
        public string CreditQuota { get; set; }

        /// <summary>
        /// 试算日利率，保留6位小数
        /// </summary>
        [XmlElement("daily_interest_rate")]
        public string DailyInterestRate { get; set; }

        /// <summary>
        /// 支用试算扩展信息
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 拒绝必填，支用拒绝原因code
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 咨询不准入时拒绝原因描述
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 放款机构
        /// </summary>
        [XmlElement("fund_supplier")]
        public SideloanInstitution FundSupplier { get; set; }

        /// <summary>
        /// 还款计划明细列表
        /// </summary>
        [XmlArray("installment_plan_list")]
        [XmlArrayItem("installment_plan")]
        public List<InstallmentPlan> InstallmentPlanList { get; set; }

        /// <summary>
        /// 10.00，利息 ，单位元（如果有卡券优惠则时，则是使用优惠后的最终利息）,保留小数点后两位
        /// </summary>
        [XmlElement("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 试算的最终的年化利率，0.18代表年化利率18%，保留小数点6位
        /// </summary>
        [XmlElement("interest_rate")]
        public string InterestRate { get; set; }

        /// <summary>
        /// 本金 ，单位元,保留小数点后两位
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 减免金额，由于优惠减免了多少利息
        /// </summary>
        [XmlElement("promotion_amount")]
        public string PromotionAmount { get; set; }

        /// <summary>
        /// 还款日
        /// </summary>
        [XmlElement("repayment_day")]
        public long RepaymentDay { get; set; }

        /// <summary>
        /// 标识从此调用结果
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 二级错误码
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 二级错误描述
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }

        /// <summary>
        /// 剩余可用授信额度，单位元，保留小数点后两位
        /// </summary>
        [XmlElement("surplus_quota")]
        public string SurplusQuota { get; set; }

        /// <summary>
        /// 总金额 ，单位元,保留小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
