using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleRulelistQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleRulelistQueryResponse : AopResponse
    {
        /// <summary>
        /// [{"ruledesc":"圈人规则0","ruleid":"230291","status":"ENABLE"},  {"ruledesc":"圈人规则1","ruleid":"230292","status":"ENABLE"}]  说明:  ruledesc:规则描述信息  ruleid：规则id（唯一）  status：ENABLE（规则可使用），DISABLE（不可用）
        /// </summary>
        [XmlArray("rulelist")]
        [XmlArrayItem("crowd_rule_info")]
        public List<CrowdRuleInfo> Rulelist { get; set; }
    }
}
