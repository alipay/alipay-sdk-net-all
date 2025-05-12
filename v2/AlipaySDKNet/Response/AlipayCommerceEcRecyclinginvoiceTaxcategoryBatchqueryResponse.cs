using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceTaxcategoryBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceTaxcategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlArray("tax_category_list")]
        [XmlArrayItem("tax_category")]
        public List<TaxCategory> TaxCategoryList { get; set; }
    }
}
