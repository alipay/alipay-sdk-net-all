using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCategoryBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingCategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("careertrainingsaas_category_v_o")]
        public List<CareertrainingsaasCategoryVO> List { get; set; }
    }
}
