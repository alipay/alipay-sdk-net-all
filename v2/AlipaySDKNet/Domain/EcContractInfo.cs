using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcContractInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcContractInfo : AopObject
    {
        /// <summary>
        /// 合约解约时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 合约id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [XmlElement("contract_title")]
        public string ContractTitle { get; set; }

        /// <summary>
        /// 甲方id
        /// </summary>
        [XmlElement("first_party_id")]
        public string FirstPartyId { get; set; }

        /// <summary>
        /// 甲方名称
        /// </summary>
        [XmlElement("first_party_name")]
        public string FirstPartyName { get; set; }

        /// <summary>
        /// 外部幂等号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 协议信息列表
        /// </summary>
        [XmlArray("protocol_info_list")]
        [XmlArrayItem("ec_protocol_info")]
        public List<EcProtocolInfo> ProtocolInfoList { get; set; }

        /// <summary>
        /// 合约场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 乙方ID
        /// </summary>
        [XmlElement("second_party_id")]
        public string SecondPartyId { get; set; }

        /// <summary>
        /// 乙方名称
        /// </summary>
        [XmlElement("second_party_name")]
        public string SecondPartyName { get; set; }

        /// <summary>
        /// 签署时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
