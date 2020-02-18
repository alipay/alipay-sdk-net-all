using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractInfoVO : AopObject
    {
        /// <summary>
        /// 审批列表
        /// </summary>
        [XmlArray("approval_infos")]
        [XmlArrayItem("contract_approval_info_v_o")]
        public List<ContractApprovalInfoVO> ApprovalInfos { get; set; }

        /// <summary>
        /// 合约金额（元）
        /// </summary>
        [XmlElement("contract_amount")]
        public string ContractAmount { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 币种（如：CNY）
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 统计口径
        /// </summary>
        [XmlElement("stats_type")]
        public string StatsType { get; set; }
    }
}
