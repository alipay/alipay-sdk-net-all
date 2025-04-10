using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionModifyModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id （该字段将废弃，不建议使用，可用enterprise_id字段替换） 当前字段已废弃(推荐使用enterprise_id)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号 （该字段将废弃，不建议使用，可用enterprise_id字段替换） 当前字段已废弃(推荐使用enterprise_id)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控咨询模式： 0-支付宝内部计算规则可用金额 1-咨询外部服务商规则可用金额
        /// </summary>
        [XmlElement("consult_mode")]
        public string ConsultMode { get; set; }

        /// <summary>
        /// 制度是否启用
        /// </summary>
        [XmlElement("effective")]
        public string Effective { get; set; }

        /// <summary>
        /// 制度生效结束时间（可空），最小粒度为天，最早是当日
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
        /// 修改的发放规则详情
        /// </summary>
        [XmlElement("modify_issue_rule_detail_info")]
        public ModifyIssueRuleDetailInfo ModifyIssueRuleDetailInfo { get; set; }

        /// <summary>
        /// 制度下适用范围修改信息
        /// </summary>
        [XmlElement("modify_scope_info")]
        public ModifyScopeInfo ModifyScopeInfo { get; set; }

        /// <summary>
        /// 修改的使用规则详情
        /// </summary>
        [XmlElement("modify_standard_detail_info")]
        public ModifyStandardDetailInfo ModifyStandardDetailInfo { get; set; }
    }
}
