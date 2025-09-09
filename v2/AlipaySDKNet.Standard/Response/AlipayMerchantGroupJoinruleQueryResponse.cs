using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupJoinruleQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupJoinruleQueryResponse : AopResponse
    {
        /// <summary>
        /// 入群规则列表
        /// </summary>
        [XmlArray("group_join_rules")]
        [XmlArrayItem("group_join_rule_v_o")]
        public List<GroupJoinRuleVO> GroupJoinRules { get; set; }
    }
}
