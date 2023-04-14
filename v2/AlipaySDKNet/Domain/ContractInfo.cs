using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContractInfo : AopObject
    {
        /// <summary>
        /// 合同金额（元）
        /// </summary>
        [XmlElement("contract_amount")]
        public string ContractAmount { get; set; }

        /// <summary>
        /// 合同文件信息列表
        /// </summary>
        [XmlArray("contract_file_infos")]
        [XmlArrayItem("contract_file_info")]
        public List<ContractFileInfo> ContractFileInfos { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 币种（如：CNY）
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 合同对手方公司名称列表
        /// </summary>
        [XmlArray("parse_participant_infos")]
        [XmlArrayItem("string")]
        public List<string> ParseParticipantInfos { get; set; }

        /// <summary>
        /// 合同本方公司名称列表
        /// </summary>
        [XmlArray("self_participant_infos")]
        [XmlArrayItem("string")]
        public List<string> SelfParticipantInfos { get; set; }
    }
}
