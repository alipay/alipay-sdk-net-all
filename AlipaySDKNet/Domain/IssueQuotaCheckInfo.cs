using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IssueQuotaCheckInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IssueQuotaCheckInfo : AopObject
    {
        /// <summary>
        /// 发放金额
        /// </summary>
        [XmlElement("issue_quota")]
        public string IssueQuota { get; set; }

        /// <summary>
        /// 校验结果的原因
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 入参的 owner_id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 入参的  owner_open_id
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// owner_type
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 校验结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
