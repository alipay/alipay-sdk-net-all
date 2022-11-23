using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionDetailinfoQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionDetailinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 制度启用停用状态 0-停用，1-启用
        /// </summary>
        [XmlElement("effective")]
        public string Effective { get; set; }

        /// <summary>
        /// 制度生效结束时间，最小粒度为天，结束时间不早于起始时间，时分秒必须为23:59:59，最晚不超过2222-01-01 23:59:59
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 制度生效起始时间，最小粒度为天，最早是当日，时分秒必须为00:00:00。
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 费用类型 枚举值：MEAL（餐饮），DEFAULT（通用）
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 制度描述
        /// </summary>
        [XmlElement("institution_desc")]
        public string InstitutionDesc { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 制度名称
        /// </summary>
        [XmlElement("institution_name")]
        public string InstitutionName { get; set; }

        /// <summary>
        /// 发放规则列表
        /// </summary>
        [XmlArray("issue_rule_info_list")]
        [XmlArrayItem("issue_rule_info")]
        public List<IssueRuleInfo> IssueRuleInfoList { get; set; }

        /// <summary>
        /// 因公场景 ，枚举值：OVERTIME（加班），SUBSIDY（补贴福利），TRAVEL（差旅），ENTERTAIN（招待），DEFAULT（通用）
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 使用规则列表
        /// </summary>
        [XmlArray("standard_info_detail_list")]
        [XmlArrayItem("standard_info")]
        public List<StandardInfo> StandardInfoDetailList { get; set; }

        /// <summary>
        /// 使用规则列表（已废弃，请使用：standard_info_detail_list）
        /// </summary>
        [XmlElement("standard_info_list")]
        public StandardInfo StandardInfoList { get; set; }
    }
}
