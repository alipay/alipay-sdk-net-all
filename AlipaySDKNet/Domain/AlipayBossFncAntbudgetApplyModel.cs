using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncAntbudgetApplyModel : AopObject
    {
        /// <summary>
        /// 申请参数列表
        /// </summary>
        [XmlArray("apply_biz_budget_request_list")]
        [XmlArrayItem("apply_biz_budget_request")]
        public List<ApplyBizBudgetRequest> ApplyBizBudgetRequestList { get; set; }

        /// <summary>
        /// 幂等字段
        /// </summary>
        [XmlElement("idempotent_id")]
        public string IdempotentId { get; set; }
    }
}
