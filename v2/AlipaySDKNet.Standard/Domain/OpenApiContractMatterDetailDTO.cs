using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiContractMatterDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiContractMatterDetailDTO : AopObject
    {
        /// <summary>
        /// 合同申请人
        /// </summary>
        [XmlElement("applicant")]
        public OpenApiPersonSaDTO Applicant { get; set; }

        /// <summary>
        /// 合同申请通过时间
        /// </summary>
        [XmlElement("apply_end_time")]
        public string ApplyEndTime { get; set; }

        /// <summary>
        /// 合同申请时间
        /// </summary>
        [XmlElement("apply_start_time")]
        public string ApplyStartTime { get; set; }

        /// <summary>
        /// 合同状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_line")]
        public string BusinessLine { get; set; }

        /// <summary>
        /// 合同描述
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 各阶段定稿意见
        /// </summary>
        [XmlArray("confirm_comment_list")]
        [XmlArrayItem("open_api_comment_d_t_o")]
        public List<OpenApiCommentDTO> ConfirmCommentList { get; set; }

        /// <summary>
        /// 合同附件
        /// </summary>
        [XmlArray("contract_attach_list")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> ContractAttachList { get; set; }

        /// <summary>
        /// 合同号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 磋商协同人
        /// </summary>
        [XmlArray("contract_coordinator_list")]
        [XmlArrayItem("open_api_contract_coordinator_d_t_o")]
        public List<OpenApiContractCoordinatorDTO> ContractCoordinatorList { get; set; }

        /// <summary>
        /// 合同创建时间-业务时间
        /// </summary>
        [XmlElement("contract_create_time")]
        public string ContractCreateTime { get; set; }

        /// <summary>
        /// 合同文件
        /// </summary>
        [XmlArray("contract_doc_list")]
        [XmlArrayItem("open_api_contract_file_sa_d_t_o")]
        public List<OpenApiContractFileSaDTO> ContractDocList { get; set; }

        /// <summary>
        /// 磋商合同文件list
        /// </summary>
        [XmlArray("contract_file_results")]
        [XmlArrayItem("open_api_contract_file_d_t_o")]
        public List<OpenApiContractFileDTO> ContractFileResults { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 商业关系，我方（甲方）
        /// </summary>
        [XmlArray("contract_partner_a_dto_list")]
        [XmlArrayItem("open_api_partner_sa_d_t_o")]
        public List<OpenApiPartnerSaDTO> ContractPartnerADtoList { get; set; }

        /// <summary>
        /// 商业关系，对方（乙方）
        /// </summary>
        [XmlArray("contract_partner_b_dto_list")]
        [XmlArrayItem("open_api_partner_sa_d_t_o")]
        public List<OpenApiPartnerSaDTO> ContractPartnerBDtoList { get; set; }

        /// <summary>
        /// 纸质用印
        /// </summary>
        [XmlElement("contract_sign_type")]
        public string ContractSignType { get; set; }

        /// <summary>
        /// 合同模板ID
        /// </summary>
        [XmlElement("contract_template_code")]
        public string ContractTemplateCode { get; set; }

        /// <summary>
        /// 业法工作台合同详情地址
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 合同生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 合同失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 接口财务
        /// </summary>
        [XmlArray("finance_people")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> FinancePeople { get; set; }

        /// <summary>
        /// 是否模板，只有受理之后的合同才会返回这个字段
        /// </summary>
        [XmlElement("is_template")]
        public bool IsTemplate { get; set; }

        /// <summary>
        /// 接口法务
        /// </summary>
        [XmlArray("legal_people")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> LegalPeople { get; set; }

        /// <summary>
        /// 磋商事项附件
        /// </summary>
        [XmlArray("matter_attachment_results")]
        [XmlArrayItem("open_api_contract_file_d_t_o")]
        public List<OpenApiContractFileDTO> MatterAttachmentResults { get; set; }

        /// <summary>
        /// 磋商code
        /// </summary>
        [XmlElement("matter_code")]
        public string MatterCode { get; set; }

        /// <summary>
        /// 磋商成员评论集合
        /// </summary>
        [XmlArray("matter_comment_list")]
        [XmlArrayItem("open_api_matter_comment_d_t_o")]
        public List<OpenApiMatterCommentDTO> MatterCommentList { get; set; }

        /// <summary>
        /// 合同份数
        /// </summary>
        [XmlElement("number")]
        public long Number { get; set; }

        /// <summary>
        /// 作废前原始业务状态
        /// </summary>
        [XmlElement("origin_biz_status")]
        public string OriginBizStatus { get; set; }

        /// <summary>
        /// 合同负责人
        /// </summary>
        [XmlArray("owners")]
        [XmlArrayItem("open_api_person_sa_d_t_o")]
        public List<OpenApiPersonSaDTO> Owners { get; set; }

        /// <summary>
        /// 关联事项
        /// </summary>
        [XmlArray("relate_matter_list")]
        [XmlArrayItem("open_api_relate_matter_d_t_o")]
        public List<OpenApiRelateMatterDTO> RelateMatterList { get; set; }

        /// <summary>
        /// 页面展示的状态
        /// </summary>
        [XmlElement("show_biz_status")]
        public string ShowBizStatus { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
