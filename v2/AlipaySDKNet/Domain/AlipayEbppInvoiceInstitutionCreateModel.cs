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
        /// 企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换） 当前字段已废弃(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 制度适配范围 当前字段已废弃(请使用institution_scope_info中adapter_type)
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换） 当前字段已废弃(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控咨询模式，默认为0。
        /// </summary>
        [XmlElement("consult_mode")]
        public string ConsultMode { get; set; }

        /// <summary>
        /// 该字段用于管控制度下发放的资产币种，不填写默认为人民币，设置该字段后，制度下手工发放的资产币种均为设置值。
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 制度生效结束时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 制度生效起始时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 制度描述
        /// </summary>
        [XmlElement("institution_desc")]
        public string InstitutionDesc { get; set; }

        /// <summary>
        /// 制度名称
        /// </summary>
        [XmlElement("institution_name")]
        public string InstitutionName { get; set; }

        /// <summary>
        /// 制度适用范围信息
        /// </summary>
        [XmlElement("institution_scope_info")]
        public InstitutionScopeInfo InstitutionScopeInfo { get; set; }

        /// <summary>
        /// 发放规则列表
        /// </summary>
        [XmlArray("issue_rule_info_list")]
        [XmlArrayItem("issue_rule_info")]
        public List<IssueRuleInfo> IssueRuleInfoList { get; set; }

        /// <summary>
        /// 制度下额度是否支持多人共享。如果支持，则制度下资产所有人共享；如果不支持，则制度下的资产为个人资产，成员之间不共享。
        /// </summary>
        [XmlElement("multi_employee_share_mode")]
        public string MultiEmployeeShareMode { get; set; }

        /// <summary>
        /// 外部唯一标识，可用于防止重复创建
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 适配id列表 当前字段已废弃(请使用institution_scope_info中owner_id_list)
        /// </summary>
        [XmlArray("owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> OwnerIdList { get; set; }

        /// <summary>
        /// 适配开放id列表 当前字段已废弃(仅存量使用员工支付宝id配置适配范围的场景需要该字段，新对接方案不推荐使用员工支付宝id)
        /// </summary>
        [XmlArray("owner_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OwnerOpenIdList { get; set; }

        /// <summary>
        /// 适配id类型 当前字段已废弃(请使用institution_scope_info中owner_type)
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 因公场景 当前字段已废弃(该字段将废弃，不建议使用)
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
