using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpConsumeRestrictionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpConsumeRestrictionInfo : AopObject
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
        /// 企业信息
        /// </summary>
        [XmlElement("enterprise_information")]
        public string EnterpriseInformation { get; set; }

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
        /// 限制消费人员姓名
        /// </summary>
        [XmlElement("xzxfryxm")]
        public string Xzxfryxm { get; set; }
    }
}
