using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceRecommendResponse.
    /// </summary>
    public class AlipayCommerceOfflinelaborInsuranceRecommendResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("recom_product_plan_list")]
        [XmlArrayItem("offline_labor_recom_insurance_product")]
        public List<OfflineLaborRecomInsuranceProduct> RecomProductPlanList { get; set; }
    }
}
