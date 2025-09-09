using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCourtNoticeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCourtNoticeInfo : AopObject
    {
        /// <summary>
        /// 所属地区
        /// </summary>
        [XmlElement("affiliating_area")]
        public EpSubordinateRegionalInfo AffiliatingArea { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 案由
        /// </summary>
        [XmlElement("case_cause")]
        public string CaseCause { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_no")]
        public string CaseNo { get; set; }

        /// <summary>
        /// 法院
        /// </summary>
        [XmlElement("court")]
        public string Court { get; set; }

        /// <summary>
        /// 开庭时间
        /// </summary>
        [XmlElement("court_date")]
        public string CourtDate { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 其他角色
        /// </summary>
        [XmlArray("other_roles")]
        [XmlArrayItem("string")]
        public List<string> OtherRoles { get; set; }

        /// <summary>
        /// 当事人详情
        /// </summary>
        [XmlArray("parties_details")]
        [XmlArrayItem("ep_parties_details_info")]
        public List<EpPartiesDetailsInfo> PartiesDetails { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("titles")]
        public string Titles { get; set; }
    }
}
