using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceCreateLeadsParams Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceCreateLeadsParams : AopObject
    {
        /// <summary>
        /// 实际主导方
        /// </summary>
        [XmlElement("actual_lead_party")]
        public string ActualLeadParty { get; set; }

        /// <summary>
        /// 阿里云结算模式枚举值
        /// </summary>
        [XmlElement("alicloud_settlement_mode")]
        public string AlicloudSettlementMode { get; set; }

        /// <summary>
        /// 云平台区域 (公共云)
        /// </summary>
        [XmlElement("cloud_platform_region")]
        public string CloudPlatformRegion { get; set; }

        /// <summary>
        /// 创建人的工号
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// crm客户编码
        /// </summary>
        [XmlElement("crm_customer_id")]
        public string CrmCustomerId { get; set; }

        /// <summary>
        /// crm客户行业
        /// </summary>
        [XmlElement("crm_customer_industry")]
        public string CrmCustomerIndustry { get; set; }

        /// <summary>
        /// crm客户行业id
        /// </summary>
        [XmlElement("crm_customer_industry_id")]
        public string CrmCustomerIndustryId { get; set; }

        /// <summary>
        /// crm客户名称
        /// </summary>
        [XmlElement("crm_customer_name")]
        public string CrmCustomerName { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 平台类型（公共云）
        /// </summary>
        [XmlElement("deploy_platform")]
        public string DeployPlatform { get; set; }

        /// <summary>
        /// 部署方式
        /// </summary>
        [XmlElement("deploy_type")]
        public string DeployType { get; set; }

        /// <summary>
        /// 预计签约日期
        /// </summary>
        [XmlElement("expect_sign_date")]
        public string ExpectSignDate { get; set; }

        /// <summary>
        /// 最终客户签约对方主体ID
        /// </summary>
        [XmlElement("final_customer_sign_other_party_subject_id")]
        public string FinalCustomerSignOtherPartySubjectId { get; set; }

        /// <summary>
        /// 最终客户签约对方主体名称
        /// </summary>
        [XmlElement("final_customer_sign_other_party_subject_name")]
        public string FinalCustomerSignOtherPartySubjectName { get; set; }

        /// <summary>
        /// 最终客户签约主体ID
        /// </summary>
        [XmlElement("final_customer_sign_subject_id")]
        public string FinalCustomerSignSubjectId { get; set; }

        /// <summary>
        /// 最终客户签约主体名称
        /// </summary>
        [XmlElement("final_customer_sign_subject_name")]
        public string FinalCustomerSignSubjectName { get; set; }

        /// <summary>
        /// 总代合作类型枚举值
        /// </summary>
        [XmlElement("general_agent_cooperation_type")]
        public string GeneralAgentCooperationType { get; set; }

        /// <summary>
        /// 商机编码
        /// </summary>
        [XmlElement("leads_code")]
        public string LeadsCode { get; set; }

        /// <summary>
        /// 部署资源云底座，多个用逗号隔开
        /// </summary>
        [XmlElement("leads_deploy_resource_pedestals")]
        public string LeadsDeployResourcePedestals { get; set; }

        /// <summary>
        /// 商机收费模式
        /// </summary>
        [XmlElement("leads_fee_model")]
        public string LeadsFeeModel { get; set; }

        /// <summary>
        /// 诺曼底商机
        /// </summary>
        [XmlElement("leads_normandy")]
        public string LeadsNormandy { get; set; }

        /// <summary>
        /// 其他云底座文本值
        /// </summary>
        [XmlElement("leads_other_cloud_pedestal")]
        public string LeadsOtherCloudPedestal { get; set; }

        /// <summary>
        /// 其他伙伴，保存ID，多个逗号隔开
        /// </summary>
        [XmlElement("leads_other_partners")]
        public string LeadsOtherPartners { get; set; }

        /// <summary>
        /// 其他伙伴名字
        /// </summary>
        [XmlElement("leads_other_partners_name")]
        public string LeadsOtherPartnersName { get; set; }

        /// <summary>
        /// 商机产品类别
        /// </summary>
        [XmlElement("leads_product_type")]
        public string LeadsProductType { get; set; }

        /// <summary>
        /// 商机售卖渠道
        /// </summary>
        [XmlElement("leads_sale_channel")]
        public string LeadsSaleChannel { get; set; }

        /// <summary>
        /// 商机售卖地域
        /// </summary>
        [XmlElement("leads_sale_territory")]
        public string LeadsSaleTerritory { get; set; }

        /// <summary>
        /// 商机来源伙伴pid
        /// </summary>
        [XmlElement("leads_source_partner_id")]
        public string LeadsSourcePartnerId { get; set; }

        /// <summary>
        /// OB签约对方主体ID
        /// </summary>
        [XmlElement("ob_sign_other_party_subject_id")]
        public string ObSignOtherPartySubjectId { get; set; }

        /// <summary>
        /// OB签约对方主体名称
        /// </summary>
        [XmlElement("ob_sign_other_party_subject_name")]
        public string ObSignOtherPartySubjectName { get; set; }

        /// <summary>
        /// 海图商机编码（用于国内外商机转移）
        /// </summary>
        [XmlElement("obg_leads_code")]
        public string ObgLeadsCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("other_partner_pid_list")]
        [XmlArrayItem("string")]
        public List<string> OtherPartnerPidList { get; set; }

        /// <summary>
        /// 对方签约主体
        /// </summary>
        [XmlElement("other_party_sign_subject")]
        public string OtherPartySignSubject { get; set; }

        /// <summary>
        /// 对方签约主体id
        /// </summary>
        [XmlElement("other_party_sign_subject_id")]
        public string OtherPartySignSubjectId { get; set; }

        /// <summary>
        /// 我方签约主体
        /// </summary>
        [XmlElement("our_sign_subject")]
        public string OurSignSubject { get; set; }

        /// <summary>
        /// 合作伙伴pid(阿里云伙伴签约路径下需要填写）
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 合作伙伴名称(阿里云伙伴签约路径下需要填写）
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 产品家族
        /// </summary>
        [XmlElement("product_family")]
        public string ProductFamily { get; set; }

        /// <summary>
        /// 商机项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 公有云：触达中/交流中/测试中/商务中/公有云-使用中/Upsell/下线 专有云：潜在商机/确认商机/方案沟通/商务谈判?中标/签约中 已签约/专有云-使用中/项目关闭
        /// </summary>
        [XmlElement("project_phase")]
        public string ProjectPhase { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("fxiaoke_create_or_update_leads_predict_record_item_request")]
        public List<FxiaokeCreateOrUpdateLeadsPredictRecordItemRequest> RecordList { get; set; }

        /// <summary>
        /// 关联的框架项目商机id（如果是订单项目，需要关联一个框架项目
        /// </summary>
        [XmlElement("related_leads_id")]
        public string RelatedLeadsId { get; set; }

        /// <summary>
        /// 资源底座（公共云）
        /// </summary>
        [XmlElement("resource_foundation")]
        public string ResourceFoundation { get; set; }

        /// <summary>
        /// salesforce商机阶段
        /// </summary>
        [XmlElement("salesforce_phase")]
        public string SalesforcePhase { get; set; }

        /// <summary>
        /// 签约路径
        /// </summary>
        [XmlElement("sign_path")]
        public string SignPath { get; set; }

        /// <summary>
        /// 签约概率
        /// </summary>
        [XmlElement("sign_probability")]
        public string SignProbability { get; set; }

        /// <summary>
        /// 财年签约预测评估
        /// </summary>
        [XmlElement("sign_probability_year")]
        public string SignProbabilityYear { get; set; }

        /// <summary>
        /// OB签约对方主体所在地域
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 软件订阅时长乘以十，主要为了解决0.5年的问题 下游预测订单消费了商机本体的订阅时长，暂时重构工作量大，消费场景下，需要自行 / 10
        /// </summary>
        [XmlElement("software_subscription_years_expand_ten")]
        public string SoftwareSubscriptionYearsExpandTen { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 商机类型，{独立项目0，框架项目1，订单项目2，交付资源池商机3}
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
