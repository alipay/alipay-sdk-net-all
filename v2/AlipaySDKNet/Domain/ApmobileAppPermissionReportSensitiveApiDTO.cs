using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionReportSensitiveApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionReportSensitiveApiDTO : AopObject
    {
        /// <summary>
        /// 端权限检测报告-sdk调用隐私api具体情况DTO
        /// </summary>
        [XmlArray("api_used_list")]
        [XmlArrayItem("apmobile_use_api_d_t_o")]
        public List<ApmobileUseApiDTO> ApiUsedList { get; set; }

        /// <summary>
        /// 端权限检测报告-敏感信息使用总览DTO
        /// </summary>
        [XmlArray("api_used_overview_list")]
        [XmlArrayItem("apmobile_app_api_used_overview_d_t_o")]
        public List<ApmobileAppApiUsedOverviewDTO> ApiUsedOverviewList { get; set; }

        /// <summary>
        /// 敏感api调用总数
        /// </summary>
        [XmlElement("api_used_total")]
        public long ApiUsedTotal { get; set; }
    }
}
