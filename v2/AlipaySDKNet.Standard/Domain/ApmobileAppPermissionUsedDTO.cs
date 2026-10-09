using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionUsedDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionUsedDTO : AopObject
    {
        /// <summary>
        /// 端权限检测报告-隐私API调用按调用权限名称区分DTO
        /// </summary>
        [XmlArray("app_used_api_diff_api_desc_dtos")]
        [XmlArrayItem("apmobile_app_used_api_diff_api_desc_d_t_o")]
        public List<ApmobileAppUsedApiDiffApiDescDTO> AppUsedApiDiffApiDescDtos { get; set; }

        /// <summary>
        /// app自身调用权限次数
        /// </summary>
        [XmlElement("app_used_num")]
        public long AppUsedNum { get; set; }

        /// <summary>
        /// 所调用权限是否申请（0：未申请，1已申请）
        /// </summary>
        [XmlElement("is_applied")]
        public long IsApplied { get; set; }

        /// <summary>
        /// 权限是否被使用（0：未使用，1已使用）
        /// </summary>
        [XmlElement("is_used")]
        public long IsUsed { get; set; }

        /// <summary>
        /// 权限码
        /// </summary>
        [XmlElement("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        [XmlElement("permission_name")]
        public string PermissionName { get; set; }

        /// <summary>
        /// 端权限检测报告-调用某权限的SDK DTO
        /// </summary>
        [XmlArray("sdk_sensitive_used_list")]
        [XmlArrayItem("apmobile_sdk_sensitive_used_d_t_o")]
        public List<ApmobileSdkSensitiveUsedDTO> SdkSensitiveUsedList { get; set; }
    }
}
