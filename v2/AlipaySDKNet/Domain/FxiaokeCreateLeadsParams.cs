using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeCreateLeadsParams Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeCreateLeadsParams : AopObject
    {
        /// <summary>
        /// 实际主导方
        /// </summary>
        [XmlElement("actual_lead_party")]
        public string ActualLeadParty { get; set; }

        /// <summary>
        /// 阿里云BPID,多个，以英文逗号隔开
        /// </summary>
        [XmlElement("ali_cloud_bpid_list")]
        public string AliCloudBpidList { get; set; }

        /// <summary>
        /// 招标类型
        /// </summary>
        [XmlElement("bid_type")]
        public string BidType { get; set; }

        /// <summary>
        /// CBM工号列表
        /// </summary>
        [XmlArray("cbm_work_no_list")]
        [XmlArrayItem("string")]
        public List<string> CbmWorkNoList { get; set; }

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
        /// 预计招标(挂网)时间
        /// </summary>
        [XmlElement("expect_bid_date")]
        public string ExpectBidDate { get; set; }

        /// <summary>
        /// 预计签约日期
        /// </summary>
        [XmlElement("expect_sign_date")]
        public string ExpectSignDate { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否招投标0是1否
        /// </summary>
        [XmlElement("is_bid")]
        public string IsBid { get; set; }

        /// <summary>
        /// 是否出具投标授权函 0 是 1 否
        /// </summary>
        [XmlElement("is_issue_for_bid")]
        public long IsIssueForBid { get; set; }

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
        /// 其他合作伙伴（二代）
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
        /// 预计个集群对应存储空间大小（公共云）
        /// </summary>
        [XmlElement("predict_clusters_storage_capacity")]
        public long PredictClustersStorageCapacity { get; set; }

        /// <summary>
        /// 计个集群对应存储空间大小的单位：GB/TB（公共云）
        /// </summary>
        [XmlElement("predict_clusters_storage_unit")]
        public string PredictClustersStorageUnit { get; set; }

        /// <summary>
        /// 预计开通集群数量（台）（公共云）
        /// </summary>
        [XmlElement("predict_clusters_units_count")]
        public long PredictClustersUnitsCount { get; set; }

        /// <summary>
        /// 预计开通实例规格（核数C) （公共云）
        /// </summary>
        [XmlElement("predict_instance_core_count")]
        public long PredictInstanceCoreCount { get; set; }

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
        /// 公有云：触达中/交流中/测试中/商务中/使用中/Upsell/下线 专有云：潜在商机/确认商机/方案沟通/商务谈判?中标/签约中 已签约/项目关闭
        /// </summary>
        [XmlElement("project_phase")]
        public string ProjectPhase { get; set; }

        /// <summary>
        /// 传入商品类目列表
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
        /// 商机类型，枚举值{独立项目0，框架项目1，订单项目2}
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
