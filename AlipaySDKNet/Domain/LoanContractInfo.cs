using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoanContractInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LoanContractInfo : AopObject
    {
        /// <summary>
        /// 房抵贷抵押合同
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同编号 本次使用区块链上内部合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合同oss 地址
        /// </summary>
        [XmlElement("contract_oss_url")]
        public string ContractOssUrl { get; set; }
    }
}
