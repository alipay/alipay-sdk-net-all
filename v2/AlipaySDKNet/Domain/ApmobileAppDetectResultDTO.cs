using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppDetectResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppDetectResultDTO : AopObject
    {
        /// <summary>
        /// 检测项详情分析
        /// </summary>
        [XmlElement("app_permission_report_detail_dto")]
        public ApmobileAppPermissionReportDetailDTO AppPermissionReportDetailDto { get; set; }

        /// <summary>
        /// 检测报告基本信息
        /// </summary>
        [XmlElement("app_permission_report_index_dto")]
        public ApmobileAppPermissionReportIndexDTO AppPermissionReportIndexDto { get; set; }

        /// <summary>
        /// 端权限检测报告-SDK集成使用情况分析DTO
        /// </summary>
        [XmlElement("app_permission_report_sdk_dto")]
        public ApmobileAppPermissionReportSdkDTO AppPermissionReportSdkDto { get; set; }

        /// <summary>
        /// 端权限检测报告-敏感api使用分析DTO
        /// </summary>
        [XmlElement("app_permission_report_sensitive_api_dto")]
        public ApmobileAppPermissionReportSensitiveApiDTO AppPermissionReportSensitiveApiDto { get; set; }

        /// <summary>
        /// 端权限检测报告-敏感权限使用分析DTO
        /// </summary>
        [XmlElement("app_permission_report_sensitive_dto")]
        public ApmobileAppPermissionReportSensitiveDTO AppPermissionReportSensitiveDto { get; set; }

        /// <summary>
        /// 隐私合规检测结果
        /// </summary>
        [XmlElement("app_permission_report_summary_dto")]
        public ApmobileAppPermissionReportSummaryDTO AppPermissionReportSummaryDto { get; set; }
    }
}
