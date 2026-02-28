using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceCategoryBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceCategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("category_info")]
        [XmlArrayItem("axf_item_category_v_o")]
        public List<AxfItemCategoryVO> CategoryInfo { get; set; }
    }
}
