using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoContractInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcoContractInfo : AopObject
    {
        /// <summary>
        /// 合约结束时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("contract_end_time")]
        public long ContractEndTime { get; set; }

        /// <summary>
        /// 合约生效时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("contract_start_time")]
        public long ContractStartTime { get; set; }

        /// <summary>
        /// 合约扩展详细信息
        /// </summary>
        [XmlElement("detail_info")]
        public EcoContractDetailInfo DetailInfo { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部商户合约唯一标识
        /// </summary>
        [XmlElement("out_contract_id")]
        public string OutContractId { get; set; }

        /// <summary>
        /// 合约参与人信息
        /// </summary>
        [XmlArray("participant")]
        [XmlArrayItem("eco_contract_participant_info")]
        public List<EcoContractParticipantInfo> Participant { get; set; }

        /// <summary>
        /// 签署到期时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("sign_deadline_time")]
        public long SignDeadlineTime { get; set; }

        /// <summary>
        /// 双方完成签署的时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("sign_end_time")]
        public long SignEndTime { get; set; }

        /// <summary>
        /// 双方填写完成，开始签署合约的时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("sign_start_time")]
        public long SignStartTime { get; set; }

        /// <summary>
        /// 合约发起时间，时间戳格式，单位为毫秒
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
