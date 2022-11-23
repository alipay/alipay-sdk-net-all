using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaaSInvoker Data Structure.
    /// </summary>
    [Serializable]
    public class SaaSInvoker : AopObject
    {
        /// <summary>
        /// 阿里云用户ID
        /// </summary>
        [XmlElement("aliyun_user_id")]
        public string AliyunUserId { get; set; }

        /// <summary>
        /// 调用者类型
        /// </summary>
        [XmlElement("invoker_type")]
        public string InvokerType { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [XmlElement("user")]
        public string User { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
