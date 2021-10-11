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
        /// 企业支付宝Id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 抬头与企业关系表主键
        /// </summary>
        [XmlElement("title_id")]
        public string TitleId { get; set; }
    }
}
