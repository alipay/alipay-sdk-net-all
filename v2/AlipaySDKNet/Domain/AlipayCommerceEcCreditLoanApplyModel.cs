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
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 授信渠道编码
        /// </summary>
        [XmlElement("credit_channel_code")]
        public string CreditChannelCode { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 借贷申请金额，单位元
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 外部业务申请单号
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
