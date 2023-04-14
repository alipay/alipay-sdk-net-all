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
        /// 企业共同账户id，和授权签约协议号共同使用。
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号，可通过签约消息获取。配合企业共同账户id使用，当填写企业共同账户id时，此字段必填。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控咨询模式，默认为0。 0-支付宝内部计算 1-咨询外部服务商（此模式不可创建发放规则，不可创建额度相关规则的条件，消费模式需为"默认"）
        /// </summary>
        [XmlElement("consult_mode")]
        public string ConsultMode { get; set; }

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
        /// 发放规则列表（可空），一个制度下最多创建10条发放规则。咨询模式为“咨询外部服务商”时不可用
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
        /// 使用规则列表，一个制度下最多创建10条使用规则。
        /// </summary>
        [XmlArray("standard_info_list")]
        [XmlArrayItem("standard_info")]
        public List<StandardInfo> StandardInfoList { get; set; }
    }
}
