using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceCompanyQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业（商户）ID
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 企业（商户）公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业（商户）已开通产品列表
        /// </summary>
        [XmlArray("company_product_list")]
        [XmlArrayItem("company_product")]
        public List<CompanyProduct> CompanyProductList { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("company_tax_no")]
        public string CompanyTaxNo { get; set; }
    }
}
