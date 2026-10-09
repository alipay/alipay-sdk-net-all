using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppUsedApiDiffApiDescDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppUsedApiDiffApiDescDTO : AopObject
    {
        /// <summary>
        /// 端权限检测报告-隐私API调用点位 DTO
        /// </summary>
        [XmlArray("app_used_api_dtos")]
        [XmlArrayItem("apmobile_app_used_api_d_t_o")]
        public List<ApmobileAppUsedApiDTO> AppUsedApiDtos { get; set; }

        /// <summary>
        /// 权限使用数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        [XmlElement("permission_name")]
        public string PermissionName { get; set; }
    }
}
