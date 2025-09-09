using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupcontrolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupcontrolQueryModel : AopObject
    {
        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
