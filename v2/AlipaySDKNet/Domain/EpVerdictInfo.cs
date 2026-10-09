using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpVerdictInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpVerdictInfo : AopObject
    {
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
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 判决时间
        /// </summary>
        [XmlElement("judgment_date")]
        public string JudgmentDate { get; set; }

        /// <summary>
        /// 当事人列表
        /// </summary>
        [XmlArray("parties")]
        [XmlArrayItem("ep_verdict_parties_info")]
        public List<EpVerdictPartiesInfo> Parties { get; set; }

        /// <summary>
        /// 给付金额，返回值带有单位
        /// </summary>
        [XmlElement("payment_sum")]
        public string PaymentSum { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
