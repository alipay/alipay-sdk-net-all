using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommissionRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CommissionRuleDTO : AopObject
    {
        /// <summary>
        /// 被抽佣支付宝登录号
        /// </summary>
        [XmlElement("charged_account_login_id")]
        public string ChargedAccountLoginId { get; set; }

        /// <summary>
        /// 被抽佣支付宝账号名称
        /// </summary>
        [XmlElement("charged_account_name")]
        public string ChargedAccountName { get; set; }

        /// <summary>
        /// 抽佣比例，格式如0.01
        /// </summary>
        [XmlElement("commission_ratio")]
        public string CommissionRatio { get; set; }

        /// <summary>
        /// 抽佣关系列表
        /// </summary>
        [XmlElement("commission_relation_list")]
        public CommissionRelationDTO CommissionRelationList { get; set; }

        /// <summary>
        /// 规则创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 抽佣结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 抽佣规则
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 抽佣开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
