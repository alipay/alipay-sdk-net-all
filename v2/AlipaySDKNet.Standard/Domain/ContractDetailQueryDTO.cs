using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractDetailQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractDetailQueryDTO : AopObject
    {
        /// <summary>
        /// 合同金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 金额类型
        /// </summary>
        [XmlElement("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// 合同申请通过时间
        /// </summary>
        [XmlElement("apply_end_time")]
        public string ApplyEndTime { get; set; }

        /// <summary>
        /// 申请人员信息
        /// </summary>
        [XmlElement("apply_people")]
        public OpenApiPeopleDTO ApplyPeople { get; set; }

        /// <summary>
        /// 合同申请时间
        /// </summary>
        [XmlElement("apply_start_time")]
        public string ApplyStartTime { get; set; }

        /// <summary>
        /// 审批操作记录信息
        /// </summary>
        [XmlArray("approve_node_info_list")]
        [XmlArrayItem("approve_node_page_group_d_t_o")]
        public List<ApproveNodePageGroupDTO> ApproveNodeInfoList { get; set; }

        /// <summary>
        /// 自动续约周期
        /// </summary>
        [XmlElement("auto_renew_period")]
        public long AutoRenewPeriod { get; set; }

        /// <summary>
        /// 自动续约周期单位
        /// </summary>
        [XmlElement("auto_renew_period_unit")]
        public string AutoRenewPeriodUnit { get; set; }

        /// <summary>
        /// 业务状态
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
        /// 区块链签约时用印顺序
        /// </summary>
        [XmlElement("chain_sign_order")]
        public string ChainSignOrder { get; set; }

        /// <summary>
        /// 合同描述
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 合同附件
        /// </summary>
        [XmlArray("contract_attach_list")]
        [XmlArrayItem("contract_open_api_attach_d_t_o")]
        public List<ContractOpenApiAttachDTO> ContractAttachList { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同创建时间-业务时间
        /// </summary>
        [XmlElement("contract_create_time")]
        public string ContractCreateTime { get; set; }

        /// <summary>
        /// 合同正本
        /// </summary>
        [XmlElement("contract_doc")]
        public ContractOpenApiAttachDTO ContractDoc { get; set; }

        /// <summary>
        /// 合同有效时长
        /// </summary>
        [XmlElement("contract_duration")]
        public string ContractDuration { get; set; }

        /// <summary>
        /// 合同有效时长单位
        /// </summary>
        [XmlElement("contract_duration_unit")]
        public string ContractDurationUnit { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 商业关系，我方（甲方）
        /// </summary>
        [XmlArray("contract_partner_a_list")]
        [XmlArrayItem("open_api_partner_d_t_o")]
        public List<OpenApiPartnerDTO> ContractPartnerAList { get; set; }

        /// <summary>
        /// 商业关系，对方（乙方）
        /// </summary>
        [XmlArray("contract_partner_b_list")]
        [XmlArrayItem("open_api_partner_d_t_o")]
        public List<OpenApiPartnerDTO> ContractPartnerBList { get; set; }

        /// <summary>
        /// 签约类型
        /// </summary>
        [XmlElement("contract_sign_type")]
        public string ContractSignType { get; set; }

        /// <summary>
        /// 合同模板ID
        /// </summary>
        [XmlElement("contract_tempalte_code")]
        public string ContractTempalteCode { get; set; }

        /// <summary>
        /// 区块链签约参与人
        /// </summary>
        [XmlElement("corp_entity_list")]
        public string CorpEntityList { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 我方先用印交件方式
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 合同生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 生效方式
        /// </summary>
        [XmlElement("effect_type")]
        public string EffectType { get; set; }

        /// <summary>
        /// 合同失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 一级合同类型
        /// </summary>
        [XmlElement("first_contract_type")]
        public string FirstContractType { get; set; }

        /// <summary>
        /// 合同交还类型，纸质用印必填
        /// </summary>
        [XmlElement("give_back_type")]
        public string GiveBackType { get; set; }

        /// <summary>
        /// 上次更新时间
        /// </summary>
        [XmlElement("gm_mofified")]
        public string GmMofified { get; set; }

        /// <summary>
        /// 创建时间-系统
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 合同负责人员信息
        /// </summary>
        [XmlArray("in_charge_people_list")]
        [XmlArrayItem("open_api_people_d_t_o")]
        public List<OpenApiPeopleDTO> InChargePeopleList { get; set; }

        /// <summary>
        /// 合同失效方式
        /// </summary>
        [XmlElement("in_effect_type")]
        public string InEffectType { get; set; }

        /// <summary>
        /// 开票方
        /// </summary>
        [XmlElement("invoice_target")]
        public string InvoiceTarget { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 是否是模板合同
        /// </summary>
        [XmlElement("is_template")]
        public bool IsTemplate { get; set; }

        /// <summary>
        /// 法务人员信息
        /// </summary>
        [XmlArray("legal_peoples")]
        [XmlArrayItem("open_api_people_d_t_o")]
        public List<OpenApiPeopleDTO> LegalPeoples { get; set; }

        /// <summary>
        /// 磋商code
        /// </summary>
        [XmlElement("matter_code")]
        public string MatterCode { get; set; }

        /// <summary>
        /// OpenApiMatterMemberDTO
        /// </summary>
        [XmlArray("matter_member_list")]
        [XmlArrayItem("open_api_matter_member_d_t_o")]
        public List<OpenApiMatterMemberDTO> MatterMemberList { get; set; }

        /// <summary>
        /// 合同份数
        /// </summary>
        [XmlElement("number")]
        public long Number { get; set; }

        /// <summary>
        /// 对方关联公司列表
        /// </summary>
        [XmlArray("other_relate_company_list")]
        [XmlArrayItem("open_api_partner_d_t_o")]
        public List<OpenApiPartnerDTO> OtherRelateCompanyList { get; set; }

        /// <summary>
        /// 我方关联公司列表
        /// </summary>
        [XmlArray("our_relate_company_list")]
        [XmlArrayItem("open_api_partner_d_t_o")]
        public List<OpenApiPartnerDTO> OurRelateCompanyList { get; set; }

        /// <summary>
        /// 付款方
        /// </summary>
        [XmlElement("payer")]
        public string Payer { get; set; }

        /// <summary>
        /// 支付条款
        /// </summary>
        [XmlArray("payment_terms_list")]
        [XmlArrayItem("open_api_payment_terms_d_t_o")]
        public List<OpenApiPaymentTermsDTO> PaymentTermsList { get; set; }

        /// <summary>
        /// 实体章用印备注
        /// </summary>
        [XmlElement("remarks_on_printing")]
        public string RemarksOnPrinting { get; set; }

        /// <summary>
        /// 纸质用印时的用印顺序
        /// </summary>
        [XmlElement("seal_order")]
        public string SealOrder { get; set; }

        /// <summary>
        /// 二级合同类型
        /// </summary>
        [XmlElement("second_contract_type")]
        public string SecondContractType { get; set; }

        /// <summary>
        /// 页面展示的状态
        /// </summary>
        [XmlElement("show_biz_status")]
        public string ShowBizStatus { get; set; }

        /// <summary>
        /// 签约实例ID
        /// </summary>
        [XmlElement("sign_instant_id")]
        public string SignInstantId { get; set; }

        /// <summary>
        /// 来源系统ID
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tanant")]
        public string Tanant { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public long TaxRate { get; set; }
    }
}
