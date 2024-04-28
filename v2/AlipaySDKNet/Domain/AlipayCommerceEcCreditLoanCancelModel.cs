using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditLoanCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditLoanCancelModel : AopObject
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
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
