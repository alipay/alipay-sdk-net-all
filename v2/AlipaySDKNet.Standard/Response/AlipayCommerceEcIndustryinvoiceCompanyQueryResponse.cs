using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceCompanyQueryResponse.
    /// </summary>
    public class AlipayCommerceEcIndustryinvoiceCompanyQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业已开通产品列表
        /// </summary>
        [XmlArray("company_product_info_list")]
        [XmlArrayItem("company_product_info")]
        public List<CompanyProductInfo> CompanyProductInfoList { get; set; }

        /// <summary>
        /// 企业开票员信息
        /// </summary>
        [XmlElement("invoice_clerk")]
        public CompanyInvoiceClerk InvoiceClerk { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
