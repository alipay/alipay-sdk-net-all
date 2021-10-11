using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesSceneruleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesSceneruleQueryModel : AopObject
    {
        /// <summary>
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
