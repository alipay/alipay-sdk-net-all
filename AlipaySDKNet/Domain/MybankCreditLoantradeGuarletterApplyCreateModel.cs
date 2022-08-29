using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterApplyCreateModel : AopObject
    {
        /// <summary>
        /// 申请金额
        /// </summary>
        [XmlElement("apply_amt")]
        public CreditPayMoneyVO ApplyAmt { get; set; }

        /// <summary>
        /// 申请信息附件
        /// </summary>
        [XmlElement("apply_attatchments")]
        public ApplyAttatchmentVO ApplyAttatchments { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 申请企业信息
        /// </summary>
        [XmlElement("apply_user_info")]
        public EnterpriseCustomerInfoVO ApplyUserInfo { get; set; }

        /// <summary>
        /// 投标人公钥
        /// </summary>
        [XmlElement("apply_user_public_key")]
        public string ApplyUserPublicKey { get; set; }

        /// <summary>
        /// 收益人信息（招标人信息）
        /// </summary>
        [XmlElement("beneficiary_user_info")]
        public EnterpriseCustomerInfoVO BeneficiaryUserInfo { get; set; }

        /// <summary>
        /// 标的明细
        /// </summary>
        [XmlElement("bid_detail")]
        public BidDetailVO BidDetail { get; set; }

        /// <summary>
        /// 是否密文
        /// </summary>
        [XmlElement("encrypted")]
        public bool Encrypted { get; set; }

        /// <summary>
        /// 担保到期时间
        /// </summary>
        [XmlElement("guar_end_date")]
        public string GuarEndDate { get; set; }

        /// <summary>
        /// 保函生效时间
        /// </summary>
        [XmlElement("guar_start_date")]
        public string GuarStartDate { get; set; }

        /// <summary>
        /// 保函生效天数
        /// </summary>
        [XmlElement("guar_valid_days")]
        public long GuarValidDays { get; set; }

        /// <summary>
        /// 操作员信息
        /// </summary>
        [XmlElement("operator_user_info")]
        public IndividualCustomerInfoVO OperatorUserInfo { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 方案合约号
        /// </summary>
        [XmlElement("scheme_ar_no")]
        public string SchemeArNo { get; set; }
    }
}
