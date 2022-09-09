using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PurchaseRecommResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseRecommResultDTO : AopObject
    {
        /// <summary>
        /// 协议条款
        /// </summary>
        [XmlArray("agreement_list")]
        [XmlArrayItem("ins_agreement_d_t_o")]
        public List<InsAgreementDTO> AgreementList { get; set; }

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
        /// 产品编码，标识某一类产品：yfx 运费险,shx 售后险
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
        /// 产品方案id
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 推荐流水id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }

        /// <summary>
        /// 是否展示暂不投保选项
        /// </summary>
        [XmlElement("show_uninsured_option")]
        public bool ShowUninsuredOption { get; set; }
    }
}
