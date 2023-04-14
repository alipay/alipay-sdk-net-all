using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryModel : AopObject
    {
        /// <summary>
        /// 共同账户id，与enterprise_id两者必填其一
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业id，与account_id两者必填其一
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 抬头ID
        /// </summary>
        [XmlElement("title_id")]
        public string TitleId { get; set; }
    }
}
