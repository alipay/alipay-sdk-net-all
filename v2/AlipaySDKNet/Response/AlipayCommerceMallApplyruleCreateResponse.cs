using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMallApplyruleCreateResponse.
    /// </summary>
    public class AlipayCommerceMallApplyruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的规则id
        /// </summary>
        [XmlElement("biz_rule_id")]
        public string BizRuleId { get; set; }
    }
}
