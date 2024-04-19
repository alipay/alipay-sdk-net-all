using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMallApplyruleModifyResponse.
    /// </summary>
    public class AlipayCommerceMallApplyruleModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作的规则id
        /// </summary>
        [XmlElement("biz_rule_id")]
        public string BizRuleId { get; set; }
    }
}
