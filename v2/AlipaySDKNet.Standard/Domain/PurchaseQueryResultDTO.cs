using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PurchaseQueryResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseQueryResultDTO : AopObject
    {
        /// <summary>
        /// 协议条款
        /// </summary>
        [XmlArray("agreement_list")]
        [XmlArrayItem("ins_agreement_d_t_o")]
        public List<InsAgreementDTO> AgreementList { get; set; }

        /// <summary>
        /// 开始生效时间，限时订购时有效
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 结束时间，限时订购时有效
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 保险公司id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 保险公司名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 保障方案列表
        /// </summary>
        [XmlArray("insure_plans")]
        [XmlArrayItem("purchase_insure_plan_d_t_o")]
        public List<PurchaseInsurePlanDTO> InsurePlans { get; set; }

        /// <summary>
        /// 已出单量,按量订购时有效
        /// </summary>
        [XmlElement("issued_amount")]
        public long IssuedAmount { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 产品编码，标识某一类产品
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [XmlElement("product_desc")]
        public string ProductDesc { get; set; }

        /// <summary>
        /// 产品介绍页url
        /// </summary>
        [XmlElement("product_info_url")]
        public string ProductInfoUrl { get; set; }

        /// <summary>
        /// 对外产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品方案id
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 订购合约id
        /// </summary>
        [XmlElement("purchase_contract_id")]
        public string PurchaseContractId { get; set; }

        /// <summary>
        /// 订购主体id userId 或 商品id
        /// </summary>
        [XmlElement("related_subject_id")]
        public string RelatedSubjectId { get; set; }

        /// <summary>
        /// 订购主体类型 PURCHASE_USER 订购人 ECOM_ITEM  商品
        /// </summary>
        [XmlElement("related_subject_type")]
        public string RelatedSubjectType { get; set; }

        /// <summary>
        /// 是否自动续订
        /// </summary>
        [XmlElement("renew")]
        public bool Renew { get; set; }

        /// <summary>
        /// 续订期限 自动续订时有效
        /// </summary>
        [XmlElement("renew_period")]
        public InsPeriodDTO RenewPeriod { get; set; }

        /// <summary>
        /// 是否展示暂不投保选项
        /// </summary>
        [XmlElement("show_uninsured_option")]
        public bool ShowUninsuredOption { get; set; }

        /// <summary>
        /// 订购状态 生效  VALID 失效 INVALID 订购失败 FAIL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订购数量，按量订购时有效
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
