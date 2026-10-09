using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMallApplyruleDeleteResponse.
    /// </summary>
    public class AlipayCommerceMallApplyruleDeleteResponse : AopResponse
    {
        /// <summary>
        /// 业务规则id
        /// </summary>
        [XmlElement("biz_rule_id")]
        public string BizRuleId { get; set; }
    }
}
