using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageUseRule Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageUseRule : AopObject
    {
        /// <summary>
        /// 券包使用规则
        /// </summary>
        [XmlElement("use_rule_desc")]
        public string UseRuleDesc { get; set; }
    }
}
