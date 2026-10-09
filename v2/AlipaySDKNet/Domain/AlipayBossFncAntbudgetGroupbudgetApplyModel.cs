using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetGroupbudgetApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncAntbudgetGroupbudgetApplyModel : AopObject
    {
        /// <summary>
        /// 批次id，作为幂等id
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 集团预算申请集合
        /// </summary>
        [XmlArray("group_budget_apply_request_list")]
        [XmlArrayItem("gb_apply_request")]
        public List<GbApplyRequest> GroupBudgetApplyRequestList { get; set; }

        /// <summary>
        /// 命名空间 例如： 智科:ZK，业管:RESOURCE
        /// </summary>
        [XmlElement("ns")]
        public string Ns { get; set; }
    }
}
