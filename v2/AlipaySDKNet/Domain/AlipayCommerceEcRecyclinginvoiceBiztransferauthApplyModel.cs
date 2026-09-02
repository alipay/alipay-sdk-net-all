using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceBiztransferauthApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceBiztransferauthApplyModel : AopObject
    {
        /// <summary>
        /// 企业转账账户 ID，来自 `company.query` 的 `company_product_list.company_account_id`
        /// </summary>
        [XmlElement("company_account_id")]
        public string CompanyAccountId { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
