using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractDetailCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractDetailCreateModel : AopObject
    {
        /// <summary>
        /// 申请人信息
        /// </summary>
        [XmlElement("applicant")]
        public OpenApiPersonSaDTO Applicant { get; set; }

        /// <summary>
        /// 合同附件
        /// </summary>
        [XmlArray("attach_files")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> AttachFiles { get; set; }

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
        /// 合同描述
        /// </summary>
        [XmlElement("contract_desc")]
        public string ContractDesc { get; set; }

        /// <summary>
        /// 合同文件
        /// </summary>
        [XmlArray("contract_files")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> ContractFiles { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 来源系统的详情链接，例：智科双百发起合同的项目详情链接。
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

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
        /// 磋商人员信息
        /// </summary>
        [XmlArray("negotiators")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> Negotiators { get; set; }

        /// <summary>
        /// 对方主体列表
        /// </summary>
        [XmlArray("opposite_parts")]
        [XmlArrayItem("open_api_partner_sa_d_t_o")]
        public List<OpenApiPartnerSaDTO> OppositeParts { get; set; }

        /// <summary>
        /// 数据处理关系枚举值，ENTRUST("ENTRUST", "委托处理"),CROSS_OU("CROSS_OU", "跨主体数据采集/共享"),OTHER("OTHER", "其他")
        /// </summary>
        [XmlElement("ou_data_relationship")]
        public string OuDataRelationship { get; set; }

        /// <summary>
        /// 我方主体名称
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
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 合同模版
        /// </summary>
        [XmlArray("template_files")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> TemplateFiles { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 业务幂等键，由业务自行决定
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
