using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherUseRuleResult Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherUseRuleResult : AopObject
    {
        /// <summary>
        /// 商家券可用范围请求结果
        /// </summary>
        [XmlElement("voucher_available_scope_result")]
        public OrderVoucherAvailableScopeResult VoucherAvailableScopeResult { get; set; }
    }
}
