using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractWorkflowUrlResult Data Structure.
    /// </summary>
    [Serializable]
    public class ContractWorkflowUrlResult : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 审批地址
        /// </summary>
        [XmlElement("workflow_url")]
        public string WorkflowUrl { get; set; }
    }
}
