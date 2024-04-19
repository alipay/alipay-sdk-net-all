using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractBasicModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractBasicModifyModel : AopObject
    {
        /// <summary>
        /// 新增的磋商附件文件
        /// </summary>
        [XmlArray("append_attach_files")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> AppendAttachFiles { get; set; }

        /// <summary>
        /// 新增的磋商合同文件列表
        /// </summary>
        [XmlArray("append_contract_files")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> AppendContractFiles { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        [XmlElement("applicant")]
        public OpenApiPersonSaDTO Applicant { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business")]
        public string Business { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 合同号，H开头
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同背景描述
        /// </summary>
        [XmlElement("contract_desc")]
        public string ContractDesc { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 财务
        /// </summary>
        [XmlArray("finance_people")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> FinancePeople { get; set; }

        /// <summary>
        /// 法务
        /// </summary>
        [XmlArray("legal_people")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> LegalPeople { get; set; }

        /// <summary>
        /// 磋商人员列表
        /// </summary>
        [XmlArray("negotiators")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> Negotiators { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 对方公司
        /// </summary>
        [XmlArray("opposite_parts")]
        [XmlArrayItem("open_api_partner_sa_d_t_o")]
        public List<OpenApiPartnerSaDTO> OppositeParts { get; set; }

        /// <summary>
        /// 我方公司
        /// </summary>
        [XmlArray("our_parts")]
        [XmlArrayItem("open_api_partner_sa_d_t_o")]
        public List<OpenApiPartnerSaDTO> OurParts { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [XmlArray("owners")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> Owners { get; set; }

        /// <summary>
        /// 源系统id
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 更新信息的幂等键
        /// </summary>
        [XmlElement("update_id")]
        public string UpdateId { get; set; }
    }
}
