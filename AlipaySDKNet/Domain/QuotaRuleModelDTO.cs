using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaRuleModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaRuleModelDTO : AopObject
    {
        /// <summary>
        /// 该额度规则下可用金额
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 预期交易金额
        /// </summary>
        [XmlElement("excepted_amount")]
        public string ExceptedAmount { get; set; }

        /// <summary>
        /// 出资规则列表
        /// </summary>
        [XmlArray("fund_rule_list")]
        [XmlArrayItem("fund_rule_model_d_t_o")]
        public List<FundRuleModelDTO> FundRuleList { get; set; }

        /// <summary>
        /// 额度限制列表,目前支持金额限制
        /// </summary>
        [XmlArray("quota_limit_list")]
        [XmlArrayItem("quota_limit_model_d_t_o")]
        public List<QuotaLimitModelDTO> QuotaLimitList { get; set; }

        /// <summary>
        /// 规则有效期
        /// </summary>
        [XmlElement("validity_period")]
        public string ValidityPeriod { get; set; }
    }
}
