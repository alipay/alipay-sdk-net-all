using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MyxiaojinFinanceBudgetApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MyxiaojinFinanceBudgetApplyModel : AopObject
    {
        /// <summary>
        /// 申请参数列表
        /// </summary>
        [XmlArray("apply_biz_budget_request_list")]
        [XmlArrayItem("cfbudmac_apply_biz_budget_request")]
        public List<CfbudmacApplyBizBudgetRequest> ApplyBizBudgetRequestList { get; set; }

        /// <summary>
        /// 幂等字段
        /// </summary>
        [XmlElement("idempotent_id")]
        public string IdempotentId { get; set; }
    }
}
