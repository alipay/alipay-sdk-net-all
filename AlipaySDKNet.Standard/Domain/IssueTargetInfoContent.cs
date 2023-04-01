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
        /// 切换open_id前请使用：owner类型为PHONE时该字段表示员工手机号，owner类型为为EMPLOYEE时该字段表示为员工支付宝uid，owner类型为为ENTERPRISE_PAY_UID时该字段表示为员工企业码id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 切换open_id后请使用：owner类型，PHONE为员工手机号，EMPLOYEE为员工open_id
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// owner类型，用来表示owner_id的类型; enterprise_id支持PHONE、ENTERPRISE_PAY_UID类型；account_id支持EMPLOYEE类型
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
