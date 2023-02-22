using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentAuditResult Data Structure.
    /// </summary>
    [Serializable]
    public class ContentAuditResult : AopObject
    {
        /// <summary>
        /// 全量素材风险信息列表
        /// </summary>
        [XmlArray("content_risk_info_list")]
        [XmlArrayItem("content_risk_info")]
        public List<ContentRiskInfo> ContentRiskInfoList { get; set; }

        /// <summary>
        /// 机审是否完成
        /// </summary>
        [XmlElement("robot_check_finished")]
        public bool RobotCheckFinished { get; set; }

        /// <summary>
        /// 工单维度机审结果，枚举值。 当返回结果为空或空串时，代表机审中，尚未机审结束。 当审核失败时为ROBOT_FAIL；当工单审核成功并且命中驳回规则时为ROBOT_REVIEW_REJECT；当工单审核成功但没有命中驳回规则时为ROBOT_PASS；当状态为审核通过时，风险列表中仍然可能存在风险信息。 ROBOT_PASS：机审通过 ROBOT_REVIEW_REJECT：机审驳回 ROBOT_FAIL：机审失败
        /// </summary>
        [XmlElement("robot_status")]
        public string RobotStatus { get; set; }

        /// <summary>
        /// 审核的规则数
        /// </summary>
        [XmlElement("rule_counts")]
        public long RuleCounts { get; set; }
    }
}
