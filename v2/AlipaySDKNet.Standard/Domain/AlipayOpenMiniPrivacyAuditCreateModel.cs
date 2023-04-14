using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPrivacyAuditCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPrivacyAuditCreateModel : AopObject
    {
        /// <summary>
        /// 联系人邮箱。邮箱和联系电话不可都为空
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人电话。邮箱和联系电话不可都为空
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 隐私协议对用户公开类型,可选公开(PUBLIC)和不公开(HIDE)
        /// </summary>
        [XmlElement("public_type")]
        public string PublicType { get; set; }

        /// <summary>
        /// 咨询回复时间，单位（天）
        /// </summary>
        [XmlElement("reply_cycle")]
        public string ReplyCycle { get; set; }

        /// <summary>
        /// 数据存储地,境内：inside，境外：outside
        /// </summary>
        [XmlElement("storage_location")]
        public string StorageLocation { get; set; }

        /// <summary>
        /// 系统定义的隐私字段
        /// </summary>
        [XmlArray("system_privacy_fields")]
        [XmlArrayItem("system_privacy_field")]
        public List<SystemPrivacyField> SystemPrivacyFields { get; set; }

        /// <summary>
        /// 用户自定义隐私字段。最多支持20个
        /// </summary>
        [XmlArray("user_define_privacy_fields")]
        [XmlArrayItem("user_define_privacy_policy_field")]
        public List<UserDefinePrivacyPolicyField> UserDefinePrivacyFields { get; set; }
    }
}
