using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelBenefitbudgetQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelBenefitbudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 预算详情列表
        /// </summary>
        [XmlArray("budget_details")]
        [XmlArrayItem("benefit_budget_query_result_d_t_o")]
        public List<BenefitBudgetQueryResultDTO> BudgetDetails { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
