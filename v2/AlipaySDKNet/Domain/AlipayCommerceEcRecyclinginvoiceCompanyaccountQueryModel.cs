using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanyaccountQueryModel : AopObject
    {
        /// <summary>
        /// 企业（商户）转账账户ID
        /// </summary>
        [XmlElement("company_account_id")]
        public string CompanyAccountId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
