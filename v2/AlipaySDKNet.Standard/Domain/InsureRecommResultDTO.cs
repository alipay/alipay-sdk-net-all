using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureRecommResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsureRecommResultDTO : AopObject
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
        /// 保司图标
        /// </summary>
        [XmlElement("inst_logo")]
        public string InstLogo { get; set; }

        /// <summary>
        /// 保险公司名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 保司简称
        /// </summary>
        [XmlElement("inst_short_name")]
        public string InstShortName { get; set; }

        /// <summary>
        /// 保障方案列表
        /// </summary>
        [XmlArray("insure_plans")]
        [XmlArrayItem("insure_plan_d_t_o")]
        public List<InsurePlanDTO> InsurePlans { get; set; }

        /// <summary>
        /// 保费支付方类型:BUYER 买家 ，SELLER卖家
        /// </summary>
        [XmlElement("premium_payer_type")]
        public string PremiumPayerType { get; set; }

        /// <summary>
        /// 保险机构产品码
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 产品编码，标识某一类产品:SHX
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
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

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

        /// <summary>
        /// 保险标准产品码
        /// </summary>
        [XmlElement("sp_no")]
        public string SpNo { get; set; }
    }
}
