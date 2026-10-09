using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailQueryModel : AopObject
    {
        /// <summary>
        /// 企业 ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 开票批次 ID
        /// </summary>
        [XmlElement("summary_id")]
        public string SummaryId { get; set; }
    }
}
