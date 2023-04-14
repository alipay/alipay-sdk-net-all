using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetGroupbudgetRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncAntbudgetGroupbudgetRefundModel : AopObject
    {
        /// <summary>
        /// 批次id，作为幂等id
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 集团预算释放集合
        /// </summary>
        [XmlArray("group_budget_release_request_list")]
        [XmlArrayItem("gb_release_request")]
        public List<GbReleaseRequest> GroupBudgetReleaseRequestList { get; set; }

        /// <summary>
        /// 命名空间 例如： 智科:ZK，业管:RESOURCE
        /// </summary>
        [XmlElement("ns")]
        public string Ns { get; set; }
    }
}
