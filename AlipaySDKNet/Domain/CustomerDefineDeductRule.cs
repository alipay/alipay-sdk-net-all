using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerDefineDeductRule Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerDefineDeductRule : AopObject
    {
        /// <summary>
        /// 自定义优惠规则描述
        /// </summary>
        [XmlElement("customer_define_deduct_rule_desc")]
        public string CustomerDefineDeductRuleDesc { get; set; }
    }
}
