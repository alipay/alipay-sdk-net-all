using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRelatedPerformanceQueryResponse.
    /// </summary>
    public class ZhimaCreditEpRelatedPerformanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 行政处罚(市监)信息列表
        /// </summary>
        [XmlArray("case_info_list")]
        [XmlArrayItem("pen_case_info")]
        public List<PenCaseInfo> CaseInfoList { get; set; }

        /// <summary>
        /// 核验状态
        /// </summary>
        [XmlElement("is_verified")]
        public string IsVerified { get; set; }

        /// <summary>
        /// 实行被执行人信息列表
        /// </summary>
        [XmlArray("punish_break_list")]
        [XmlArrayItem("punish_break_info")]
        public List<PunishBreakInfo> PunishBreakList { get; set; }

        /// <summary>
        /// 被执行人信息列表
        /// </summary>
        [XmlArray("punished_list")]
        [XmlArrayItem("punished_info")]
        public List<PunishedInfo> PunishedList { get; set; }

        /// <summary>
        /// 作为法定代表人的企业信息列表
        /// </summary>
        [XmlArray("ry_pos_fr_list")]
        [XmlArrayItem("related_performance_info")]
        public List<RelatedPerformanceInfo> RyPosFrList { get; set; }

        /// <summary>
        /// 作为主要管理人员的企业信息列表
        /// </summary>
        [XmlArray("ry_pos_per_list")]
        [XmlArrayItem("related_performance_info")]
        public List<RelatedPerformanceInfo> RyPosPerList { get; set; }

        /// <summary>
        /// 作为股东的企业信息列表
        /// </summary>
        [XmlArray("ry_pos_sha_list")]
        [XmlArrayItem("related_performance_info")]
        public List<RelatedPerformanceInfo> RyPosShaList { get; set; }
    }
}
