using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileSdkSensitiveUsedDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileSdkSensitiveUsedDTO : AopObject
    {
        /// <summary>
        /// 端权限检测报告-SDK隐私API调用点位 DTO
        /// </summary>
        [XmlArray("app_used_api_dtos")]
        [XmlArrayItem("apmobile_app_used_api_d_t_o")]
        public List<ApmobileAppUsedApiDTO> AppUsedApiDtos { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        [XmlElement("permission_id")]
        public string PermissionId { get; set; }

        /// <summary>
        /// sdk名称
        /// </summary>
        [XmlElement("sdk_name")]
        public string SdkName { get; set; }

        /// <summary>
        /// SDK调用权限次数
        /// </summary>
        [XmlElement("sdk_used_num")]
        public long SdkUsedNum { get; set; }
    }
}
