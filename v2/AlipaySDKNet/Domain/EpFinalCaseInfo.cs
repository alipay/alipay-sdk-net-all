using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpFinalCaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpFinalCaseInfo : AopObject
    {
        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_no")]
        public string CaseNo { get; set; }

        /// <summary>
        /// 立案时间
        /// </summary>
        [XmlElement("case_register_date")]
        public string CaseRegisterDate { get; set; }

        /// <summary>
        /// 终本日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [XmlElement("execution_court")]
        public string ExecutionCourt { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 未履行金额，单位元
        /// </summary>
        [XmlElement("outstanding_amount")]
        public string OutstandingAmount { get; set; }

        /// <summary>
        /// 被执行人姓名/名称
        /// </summary>
        [XmlElement("performed_name")]
        public string PerformedName { get; set; }

        /// <summary>
        /// 执行标的，单位元
        /// </summary>
        [XmlElement("xzbd")]
        public string Xzbd { get; set; }
    }
}
