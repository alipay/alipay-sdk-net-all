using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupcontrolStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupcontrolStatusModifyModel : AopObject
    {
        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
