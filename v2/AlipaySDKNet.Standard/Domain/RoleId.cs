using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoleId Data Structure.
    /// </summary>
    [Serializable]
    public class RoleId : AopObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId_ { get; set; }
    }
}
