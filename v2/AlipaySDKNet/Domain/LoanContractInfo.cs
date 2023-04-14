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
        /// 合同编码
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同结束时间
        /// </summary>
        [XmlElement("contract_end_date")]
        public string ContractEndDate { get; set; }

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

        /// <summary>
        /// 合同签约时间
        /// </summary>
        [XmlElement("contract_sign_date")]
        public string ContractSignDate { get; set; }

        /// <summary>
        /// 合同版本
        /// </summary>
        [XmlElement("contract_version")]
        public string ContractVersion { get; set; }
    }
}
