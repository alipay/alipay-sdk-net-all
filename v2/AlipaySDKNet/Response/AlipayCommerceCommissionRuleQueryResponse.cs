using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommissionRuleQueryResponse.
    /// </summary>
    public class AlipayCommerceCommissionRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 生效中的抽佣规则
        /// </summary>
        [XmlElement("active_rule")]
        public CommissionRuleDTO ActiveRule { get; set; }

        /// <summary>
        /// 待生效的抽佣规则
        /// </summary>
        [XmlElement("init_rule")]
        public CommissionRuleDTO InitRule { get; set; }
    }
}
