using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractBatchInfoOpenApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class ContractBatchInfoOpenApiResult : AopObject
    {
        /// <summary>
        /// 批次审批状态（处理中：PROCESSING；已拒绝：REFUSE；已撤销：CANCEL； 已通过：PASS）
        /// </summary>
        [XmlElement("approval_status")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 合约信息列表
        /// </summary>
        [XmlArray("contract_infos")]
        [XmlArrayItem("contract_info_v_o")]
        public List<ContractInfoVO> ContractInfos { get; set; }
    }
}
