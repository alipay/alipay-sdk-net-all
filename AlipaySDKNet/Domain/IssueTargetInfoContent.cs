using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IssueTargetInfoContent Data Structure.
    /// </summary>
    [Serializable]
    public class IssueTargetInfoContent : AopObject
    {
        /// <summary>
        /// 发放金额
        /// </summary>
        [XmlElement("issue_quota")]
        public string IssueQuota { get; set; }

        /// <summary>
        /// owner_id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// owner类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
