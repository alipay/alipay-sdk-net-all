using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditLoanApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditLoanApplyModel : AopObject
    {
        /// <summary>
        /// 共同账户ID 当前字段已废弃(历史兼容逻辑冗余字段增加了接口复杂性，统一移除)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号 当前字段已废弃(历史兼容逻辑冗余字段增加了接口复杂性，统一移除)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 授信渠道编码，企业码定义的授信资产类型
        /// </summary>
        [XmlElement("credit_channel_code")]
        public string CreditChannelCode { get; set; }

        /// <summary>
        /// 企业Id，企业入驻企业码时自动分配的用于唯一标识的编号
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 借贷申请金额，单位元
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 外部业务编号，调用方生成的用于唯一标识借款申请的单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
