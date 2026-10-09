using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgRoleQuery Data Structure.
    /// </summary>
    [Serializable]
    public class OrgRoleQuery : AopObject
    {
        /// <summary>
        /// 组织树节点code
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 节点类型(组织部门/业务线/自定义树)
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 主站的租户id,目前是固定值：ALIPW3CN， 以后会让用户自定义
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
