using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcVoucherSummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcVoucherSummaryQueryModel : AopObject
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
        /// 汇总批次ID
        /// </summary>
        [XmlElement("summary_id")]
        public string SummaryId { get; set; }
    }
}
