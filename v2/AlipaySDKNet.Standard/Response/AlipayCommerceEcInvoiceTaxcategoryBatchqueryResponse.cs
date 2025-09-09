using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcInvoiceTaxcategoryBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcInvoiceTaxcategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 税收分类编码列表
        /// </summary>
        [XmlArray("tax_category_list")]
        [XmlArrayItem("tax_category_info")]
        public List<TaxCategoryInfo> TaxCategoryList { get; set; }
    }
}
