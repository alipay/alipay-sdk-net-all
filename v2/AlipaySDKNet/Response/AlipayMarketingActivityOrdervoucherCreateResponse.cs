using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCreateResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCreateResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 可用范围结果
        /// </summary>
        [XmlElement("voucher_available_scope_result_info")]
        public VoucherAvailableScopeResultInfo VoucherAvailableScopeResultInfo { get; set; }

        /// <summary>
        /// 券核销规则请求结果
        /// </summary>
        [XmlElement("voucher_use_rule_result")]
        public OrderVoucherUseRuleResult VoucherUseRuleResult { get; set; }
    }
}
