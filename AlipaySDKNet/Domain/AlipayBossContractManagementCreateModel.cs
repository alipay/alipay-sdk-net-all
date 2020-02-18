using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossContractManagementCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossContractManagementCreateModel : AopObject
    {
        /// <summary>
        /// 来源（如：采购系统-ALI_PURCHASE_SYSTEM）
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 合约批次号
        /// </summary>
        [XmlElement("contract_batch_no")]
        public string ContractBatchNo { get; set; }

        /// <summary>
        /// 合同信息列表
        /// </summary>
        [XmlArray("contract_info_list")]
        [XmlArrayItem("contract_info")]
        public List<ContractInfo> ContractInfoList { get; set; }

        /// <summary>
        /// 业务方流程实列ID
        /// </summary>
        [XmlElement("process_instance_id")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 业务方需要推进的流程任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
