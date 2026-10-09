using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanschemeQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanschemeQueryResponse : AopResponse
    {
        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlArray("account_vo")]
        [XmlArrayItem("my_bk_account_v_o")]
        public List<MyBkAccountVO> AccountVo { get; set; }

        /// <summary>
        /// 警戒额度，单位元
        /// </summary>
        [XmlElement("alert_amt")]
        public string AlertAmt { get; set; }

        /// <summary>
        /// 费用列表
        /// </summary>
        [XmlArray("charge_info_list")]
        [XmlArrayItem("loan_charge_info")]
        public List<LoanChargeInfo> ChargeInfoList { get; set; }

        /// <summary>
        /// 授信有效截止日期(日期精度为天,包含截止日)，必选
        /// </summary>
        [XmlElement("credit_expire_date")]
        public string CreditExpireDate { get; set; }

        /// <summary>
        /// 授信额度，政策模型或人工审批出来的授信，单位元
        /// </summary>
        [XmlElement("credit_lmt_amt")]
        public string CreditLmtAmt { get; set; }

        /// <summary>
        /// 授信编号,允许为空
        /// </summary>
        [XmlElement("credit_no")]
        public string CreditNo { get; set; }

        /// <summary>
        /// 授信方式,包括预授信方式、自动授信方式、人工授信方式
        /// </summary>
        [XmlElement("credit_source")]
        public string CreditSource { get; set; }

        /// <summary>
        /// 授信有效起始日期(日期精度为天,包含起始日)，必选
        /// </summary>
        [XmlElement("credit_start_date")]
        public string CreditStartDate { get; set; }

        /// <summary>
        /// 利率. 年利率小数
        /// </summary>
        [XmlElement("int_rate")]
        public string IntRate { get; set; }

        /// <summary>
        /// 政策产品码(微贷的政策产品码,BC开头)
        /// </summary>
        [XmlElement("loan_policy_code")]
        public string LoanPolicyCode { get; set; }

        /// <summary>
        /// 期限,指贷款期限的长度
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 期限单位；贷款期限的长度单位，有年、月、日
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 可贷额度，单位元
        /// </summary>
        [XmlElement("loanable_amt")]
        public string LoanableAmt { get; set; }

        /// <summary>
        /// 还款方式集合
        /// </summary>
        [XmlElement("repay_mode_list")]
        public InstallmentValue RepayModeList { get; set; }

        /// <summary>
        /// 金融云产品编码
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 水位额度，单位元
        /// </summary>
        [XmlElement("water_amt")]
        public string WaterAmt { get; set; }
    }
}
