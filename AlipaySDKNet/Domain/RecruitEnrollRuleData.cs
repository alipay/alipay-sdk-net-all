using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollRuleData Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollRuleData : AopObject
    {
        /// <summary>
        /// 招商方案可提报的券的规则列表，不同的券有不同的规则。
        /// </summary>
        [XmlArray("recruit_voucher_rules")]
        [XmlArrayItem("recruit_voucher_rule")]
        public List<RecruitVoucherRule> RecruitVoucherRules { get; set; }

        /// <summary>
        /// 素材的要求，json字符串，使用时需要把此字符串解析成json对象
        /// </summary>
        [XmlElement("schema")]
        public string Schema { get; set; }
    }
}
