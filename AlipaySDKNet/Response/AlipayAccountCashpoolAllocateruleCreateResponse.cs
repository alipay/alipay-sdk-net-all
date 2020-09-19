using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountCashpoolAllocateruleCreateResponse.
    /// </summary>
    public class AlipayAccountCashpoolAllocateruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 新增规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public long RuleId { get; set; }
    }
}
