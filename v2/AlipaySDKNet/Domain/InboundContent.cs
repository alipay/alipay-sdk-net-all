using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InboundContent Data Structure.
    /// </summary>
    [Serializable]
    public class InboundContent : AopObject
    {
        /// <summary>
        /// 企业证件号，非企业信息入库时为空
        /// </summary>
        [XmlElement("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 企业的名称，非企业入库时为空
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公开的联系方式，但是不一定是电话号码，可能是邮箱或者一段描述
        /// </summary>
        [XmlArray("contact_info")]
        [XmlArrayItem("string")]
        public List<string> ContactInfo { get; set; }

        /// <summary>
        /// 企业公司工商注册的法人信息
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 入库项的详情查看链接 入库项为标讯时，为标讯详情的链接 入库项为企业时，暂时会为空
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 推荐企业的主营
        /// </summary>
        [XmlArray("main_business")]
        [XmlArrayItem("string")]
        public List<string> MainBusiness { get; set; }

        /// <summary>
        /// 推荐的企业的匹配度分数，0-100的整数
        /// </summary>
        [XmlElement("match_score")]
        public long MatchScore { get; set; }

        /// <summary>
        /// 入库标讯项时，表示标讯的公告名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 机会分析
        /// </summary>
        [XmlElement("opportunity_analysis")]
        public string OpportunityAnalysis { get; set; }

        /// <summary>
        /// 购买力得分原因
        /// </summary>
        [XmlElement("purchasing_power_rationale")]
        public string PurchasingPowerRationale { get; set; }

        /// <summary>
        /// 购买力分数，0-100的整数类型，无单位
        /// </summary>
        [XmlElement("purchasing_power_score")]
        public long PurchasingPowerScore { get; set; }

        /// <summary>
        /// 推荐当前企业的理由
        /// </summary>
        [XmlElement("recommendation_rationale")]
        public string RecommendationRationale { get; set; }

        /// <summary>
        /// 与推荐的企业相似的企业
        /// </summary>
        [XmlArray("similar_companies")]
        [XmlArrayItem("string")]
        public List<string> SimilarCompanies { get; set; }

        /// <summary>
        /// 推荐企业与相似企业的相似原因
        /// </summary>
        [XmlElement("similarity_rationale")]
        public string SimilarityRationale { get; set; }

        /// <summary>
        /// 标讯的预算金额，默认指人民币，4万则表示4万元人民币
        /// </summary>
        [XmlElement("tender_budget")]
        public string TenderBudget { get; set; }

        /// <summary>
        /// 标讯的联系人名称列表
        /// </summary>
        [XmlArray("tender_contact_name")]
        [XmlArrayItem("string")]
        public List<string> TenderContactName { get; set; }

        /// <summary>
        /// 标讯的招标截止时间
        /// </summary>
        [XmlElement("tender_deadline")]
        public string TenderDeadline { get; set; }

        /// <summary>
        /// 标讯的发布时间，可能为空
        /// </summary>
        [XmlElement("tender_publish_time")]
        public string TenderPublishTime { get; set; }

        /// <summary>
        /// 标讯的中标金额，默认指人民币，可能为空，一段描述文字
        /// </summary>
        [XmlElement("tender_winning_amount")]
        public string TenderWinningAmount { get; set; }

        /// <summary>
        /// 中标的企业名称列表
        /// </summary>
        [XmlArray("tender_winning_company")]
        [XmlArrayItem("string")]
        public List<string> TenderWinningCompany { get; set; }

        /// <summary>
        /// 招标企业名称列表
        /// </summary>
        [XmlArray("tenderee_list")]
        [XmlArrayItem("string")]
        public List<string> TendereeList { get; set; }
    }
}
