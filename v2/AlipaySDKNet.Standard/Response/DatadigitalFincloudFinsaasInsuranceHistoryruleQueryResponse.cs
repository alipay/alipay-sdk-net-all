using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceHistoryruleQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceHistoryruleQueryResponse : AopResponse
    {
        /// <summary>
        /// 历史规则列表
        /// </summary>
        [XmlArray("history_rule_items")]
        [XmlArrayItem("history_rule_v_o")]
        public List<HistoryRuleVO> HistoryRuleItems { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
