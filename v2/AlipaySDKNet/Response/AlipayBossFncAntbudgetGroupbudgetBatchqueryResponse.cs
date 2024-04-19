using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetGroupbudgetBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetGroupbudgetBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据，集团预算列表集合
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("group_budget_summary_d_t_o")]
        public List<GroupBudgetSummaryDTO> ResultData { get; set; }

        /// <summary>
        /// 返回错误信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
