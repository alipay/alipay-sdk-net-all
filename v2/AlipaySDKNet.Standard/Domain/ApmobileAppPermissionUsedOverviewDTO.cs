using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionUsedOverviewDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionUsedOverviewDTO : AopObject
    {
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
        /// 权限使用类型
        /// </summary>
        [XmlElement("permission_type")]
        public string PermissionType { get; set; }
    }
}
