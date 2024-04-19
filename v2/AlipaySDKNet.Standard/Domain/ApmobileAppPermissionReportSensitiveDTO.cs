using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionReportSensitiveDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionReportSensitiveDTO : AopObject
    {
        /// <summary>
        /// 申请的权限 (APP在Manifest文件中声明敏感权限)
        /// </summary>
        [XmlElement("permission_apply")]
        public long PermissionApply { get; set; }

        /// <summary>
        /// (过度的申请权限)在Manifest文件中声明了但未在代码中调用的敏感权限
        /// </summary>
        [XmlElement("permission_over_apply")]
        public long PermissionOverApply { get; set; }

        /// <summary>
        /// 冗余权限( 在代码中调用了但未在Manifest文件中声明的敏感权限)
        /// </summary>
        [XmlElement("permission_over_used")]
        public long PermissionOverUsed { get; set; }

        /// <summary>
        /// 申请和使用权限 (APP在Manifest文件中声明及代码中调用的敏感权限)
        /// </summary>
        [XmlElement("permission_sum")]
        public long PermissionSum { get; set; }

        /// <summary>
        /// 使用的权限(APP在代码中调用的敏感权限)
        /// </summary>
        [XmlElement("permission_used")]
        public long PermissionUsed { get; set; }

        /// <summary>
        /// 端权限检测报告-敏感权限使用总览DTO
        /// </summary>
        [XmlArray("permission_used_list")]
        [XmlArrayItem("apmobile_app_permission_used_d_t_o")]
        public List<ApmobileAppPermissionUsedDTO> PermissionUsedList { get; set; }

        /// <summary>
        /// 端权限检测报告-敏感权限使用总览DTO
        /// </summary>
        [XmlArray("permission_used_overview_list")]
        [XmlArrayItem("apmobile_app_permission_used_overview_d_t_o")]
        public List<ApmobileAppPermissionUsedOverviewDTO> PermissionUsedOverviewList { get; set; }
    }
}
