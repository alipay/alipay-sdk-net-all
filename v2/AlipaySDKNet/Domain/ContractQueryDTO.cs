using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractQueryDTO : AopObject
    {
        /// <summary>
        /// 业务系统编号（置业平台合同号）
        /// </summary>
        [XmlElement("bussiness_number")]
        public string BussinessNumber { get; set; }

        /// <summary>
        /// 合同附件，允许多个
        /// </summary>
        [XmlArray("contract_attaches")]
        [XmlArrayItem("contract_attach_d_t_o")]
        public List<ContractAttachDTO> ContractAttaches { get; set; }

        /// <summary>
        /// 合同中心合同号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同正本，只允许一个
        /// </summary>
        [XmlElement("contract_doc")]
        public ContractAttachDTO ContractDoc { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 用印数据标识
        /// </summary>
        [XmlElement("imprint_id")]
        public string ImprintId { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
