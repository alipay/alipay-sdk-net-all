using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountBalanceremindlistQueryResponse.
    /// </summary>
    public class AlipayFundAccountBalanceremindlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 计划列表数组数组类型
        /// </summary>
        [XmlArray("plan_list")]
        [XmlArrayItem("balance_remind_plan_d_t_o")]
        public List<BalanceRemindPlanDTO> PlanList { get; set; }
    }
}
