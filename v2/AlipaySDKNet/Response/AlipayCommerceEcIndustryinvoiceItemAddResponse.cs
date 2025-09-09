using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceItemAddResponse.
    /// </summary>
    public class AlipayCommerceEcIndustryinvoiceItemAddResponse : AopResponse
    {
        /// <summary>
        /// 企业商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }
    }
}
