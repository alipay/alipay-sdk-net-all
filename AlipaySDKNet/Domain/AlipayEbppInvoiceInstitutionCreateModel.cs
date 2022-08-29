using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionCreateModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id（条件必填）
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号（条件必填）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 制度生效结束时间，最小粒度为天，最早是当日
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 制度生效起始时间，最小粒度为天，最早是当日
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业id（条件必填）
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费用类型 枚举值：MEAL（餐饮），DEFAULT（通用）
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 制度描述（可空）
        /// </summary>
        [XmlElement("institution_desc")]
        public string InstitutionDesc { get; set; }

        /// <summary>
        /// 制度名称
        /// </summary>
        [XmlElement("institution_name")]
        public string InstitutionName { get; set; }

        /// <summary>
        /// 发放规则列表（可空）
        /// </summary>
        [XmlArray("issue_rule_info_list")]
        [XmlArrayItem("issue_rule_info")]
        public List<IssueRuleInfo> IssueRuleInfoList { get; set; }

        /// <summary>
        /// 因公场景。枚举值：OVERTIME（加班），SUBSIDY（补贴福利），TRAVEL（差旅），ENTERTAIN（招待），DEFAULT（通用）
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 使用规则列表
        /// </summary>
        [XmlArray("standard_info_list")]
        [XmlArrayItem("standard_info")]
        public List<StandardInfo> StandardInfoList { get; set; }
    }
}
