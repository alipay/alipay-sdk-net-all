using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PermissionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PermissionDTO : AopObject
    {
        /// <summary>
        /// businessId-唯一-权限所属服务id，表示权限服务关系-无枚举-被调方结果返回-无特殊说明
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// businessName-否-权限所属服务名称-无枚举-被调方结果返回-无特殊说明
        /// </summary>
        [XmlElement("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// permissionCode-否-权限代码-枚举：spfin.usercore.update.operator-被调方结果返回-无特殊说明
        /// </summary>
        [XmlElement("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// permissionName-否-权限名称-无枚举-被调方结果返回-无特殊说明
        /// </summary>
        [XmlElement("permission_name")]
        public string PermissionName { get; set; }
    }
}
