using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherRuleInfo : AopObject
    {
        /// <summary>
        /// 用户可通过该电话进行客服咨询
        /// </summary>
        [XmlElement("customer_service_tel")]
        public string CustomerServiceTel { get; set; }

        /// <summary>
        /// 用户可通过进入该地址进行客服咨询
        /// </summary>
        [XmlElement("customer_service_url")]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// 优惠券使用规则通用文案描述
        /// </summary>
        [XmlElement("usage_rule_text")]
        public string UsageRuleText { get; set; }

        /// <summary>
        /// 优惠券使用规则地址。用户点击「规则」直接调转到该地址对应的页面
        /// </summary>
        [XmlElement("usage_rule_url")]
        public string UsageRuleUrl { get; set; }
    }
}
