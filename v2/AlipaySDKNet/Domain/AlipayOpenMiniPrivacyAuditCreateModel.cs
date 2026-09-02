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
        /// 第三方插件信息
        /// </summary>
        [XmlArray("plugin_privacy_fields")]
        [XmlArrayItem("plugin_privacy_fields")]
        public List<PluginPrivacyFields> PluginPrivacyFields { get; set; }

        /// <summary>
        /// 隐私协议对用户公开类型,可选公开(PUBLIC)和不公开(HIDE) 当前字段已废弃(该字段值固定位PUBLIC，无需传入。)
        /// </summary>
        [XmlElement("public_type")]
        public string PublicType { get; set; }

        /// <summary>
        /// 咨询回复时间，单位（天）
        /// </summary>
        [XmlElement("reply_cycle")]
        public string ReplyCycle { get; set; }

        /// <summary>
        /// 第三方SDK信息
        /// </summary>
        [XmlArray("sdk_privacy_fields")]
        [XmlArrayItem("sdk_privacy_fields")]
        public List<SdkPrivacyFields> SdkPrivacyFields { get; set; }

        /// <summary>
        /// 数据存储地,境内：inside，境外：outside
        /// </summary>
        [XmlElement("storage_location")]
        public string StorageLocation { get; set; }

        /// <summary>
        /// 端权限隐私字段
        /// </summary>
        [XmlArray("system_permission_privacy_fields")]
        [XmlArrayItem("system_permission_privacy_fields")]
        public List<SystemPermissionPrivacyFields> SystemPermissionPrivacyFields { get; set; }

        /// <summary>
        /// 用户信息隐私字段
        /// </summary>
        [XmlArray("system_privacy_fields")]
        [XmlArrayItem("system_privacy_field")]
        public List<SystemPrivacyField> SystemPrivacyFields { get; set; }

        /// <summary>
        /// 如果需要上传自定义文档，可通过alipay.open.mini.privacy.customfile.upload接口上传文件，并将该接口的返回中，user_custom_file字段的值填入这里。
        /// </summary>
        [XmlElement("user_custom_file")]
        public string UserCustomFile { get; set; }

        /// <summary>
        /// 用户自定义隐私字段。最多支持20个
        /// </summary>
        [XmlArray("user_define_privacy_fields")]
        [XmlArrayItem("user_define_privacy_policy_field")]
        public List<UserDefinePrivacyPolicyField> UserDefinePrivacyFields { get; set; }
    }
}
