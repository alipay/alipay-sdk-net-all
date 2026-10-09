using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCheckinRuleBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCheckinRuleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 签到规则列表
        /// </summary>
        [XmlArray("rule_info_list")]
        [XmlArrayItem("edu_check_in_rule")]
        public List<EduCheckInRule> RuleInfoList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
