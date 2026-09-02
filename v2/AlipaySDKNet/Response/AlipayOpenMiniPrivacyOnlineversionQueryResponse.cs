using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPrivacyOnlineversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPrivacyOnlineversionQueryResponse : AopResponse
    {
        /// <summary>
        /// 联系人邮箱。
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人电话。
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
        /// 系统定义的隐私字段
        /// </summary>
        [XmlArray("system_privacy_fields")]
        [XmlArrayItem("system_privacy_field")]
        public List<SystemPrivacyField> SystemPrivacyFields { get; set; }

        /// <summary>
        /// 自定义文档链接
        /// </summary>
        [XmlElement("user_custom_file")]
        public string UserCustomFile { get; set; }

        /// <summary>
        /// 用户自定义隐私字段。
        /// </summary>
        [XmlArray("user_define_privacy_fields")]
        [XmlArrayItem("user_define_privacy_policy_field")]
        public List<UserDefinePrivacyPolicyField> UserDefinePrivacyFields { get; set; }
    }
}
