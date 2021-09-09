using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountDepositplanListQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountDepositplanListQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金计划列表
        /// </summary>
        [XmlArray("fund_plan_list")]
        [XmlArrayItem("simple_fund_plan_d_t_o")]
        public List<SimpleFundPlanDTO> FundPlanList { get; set; }
    }
}
