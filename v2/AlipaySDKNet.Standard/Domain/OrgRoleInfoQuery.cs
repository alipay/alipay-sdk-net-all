using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgRoleInfoQuery Data Structure.
    /// </summary>
    [Serializable]
    public class OrgRoleInfoQuery : AopObject
    {
        /// <summary>
        /// 根据当前过滤条件筛选查询角色中的人员信息. BU_LINE对应业务线 DEPT对应部门 OU对应OU ORG_TREE 对应自定义树类型
        /// </summary>
        [XmlArray("node_types")]
        [XmlArrayItem("string")]
        public List<string> NodeTypes { get; set; }

        /// <summary>
        /// 根绝角色编码集合查询蚁符相关人员信息
        /// </summary>
        [XmlArray("role_codes")]
        [XmlArrayItem("string")]
        public List<string> RoleCodes { get; set; }
    }
}
