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
        /// 切换open_id前请使用：owner类型，PHONE为员工手机号，EMPLOYEE为员工支付宝uid
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 切换open_id后请使用：owner类型，PHONE为员工手机号，EMPLOYEE为员工open_id
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

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
