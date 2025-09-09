using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAdminPenaltyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAdminPenaltyInfo : AopObject
    {
        /// <summary>
        /// 案件名称
        /// </summary>
        [XmlElement("case_name")]
        public string CaseName { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("incident_date")]
        public string IncidentDate { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 企业行政处罚当事人信息列表
        /// </summary>
        [XmlArray("parties")]
        [XmlArrayItem("ep_admin_penalty_parties_info")]
        public List<EpAdminPenaltyPartiesInfo> Parties { get; set; }

        /// <summary>
        /// 处罚事由
        /// </summary>
        [XmlArray("punish_cause")]
        [XmlArrayItem("string")]
        public List<string> PunishCause { get; set; }

        /// <summary>
        /// 处罚决定日期
        /// </summary>
        [XmlElement("punish_date")]
        public string PunishDate { get; set; }

        /// <summary>
        /// 处罚决定
        /// </summary>
        [XmlArray("punish_decision")]
        [XmlArrayItem("string")]
        public List<string> PunishDecision { get; set; }

        /// <summary>
        /// 处罚决定文书号
        /// </summary>
        [XmlElement("punish_decision_no")]
        public string PunishDecisionNo { get; set; }

        /// <summary>
        /// 处罚详情
        /// </summary>
        [XmlElement("punish_details")]
        public string PunishDetails { get; set; }

        /// <summary>
        /// 处罚依据
        /// </summary>
        [XmlArray("punish_gist")]
        [XmlArrayItem("string")]
        public List<string> PunishGist { get; set; }

        /// <summary>
        /// 处罚决定机关
        /// </summary>
        [XmlArray("punish_organ")]
        [XmlArrayItem("string")]
        public List<string> PunishOrgan { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
