using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEmploymentProductConsultResponse.
    /// </summary>
    public class AlipayInsSceneEmploymentProductConsultResponse : AopResponse
    {
        /// <summary>
        /// 推荐的产品方案列表
        /// </summary>
        [XmlArray("recom_product_plan_list")]
        [XmlArrayItem("ins_recom_product_plan")]
        public List<InsRecomProductPlan> RecomProductPlanList { get; set; }
    }
}
