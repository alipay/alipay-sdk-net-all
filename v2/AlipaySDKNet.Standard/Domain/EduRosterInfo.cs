using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduRosterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduRosterInfo : AopObject
    {
        /// <summary>
        /// 绑定状态
        /// </summary>
        [XmlElement("bind_status")]
        public bool BindStatus { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件号尾号
        /// </summary>
        [XmlElement("cert_no_tail")]
        public string CertNoTail { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 部门信息 当前字段已废弃(该字段是否数组类型定义错误)
        /// </summary>
        [XmlElement("department_info")]
        public EduDepartmentNode DepartmentInfo { get; set; }

        /// <summary>
        /// 部门信息
        /// </summary>
        [XmlArray("department_info_list")]
        [XmlArrayItem("edu_department_node")]
        public List<EduDepartmentNode> DepartmentInfoList { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 学号或工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 失效过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 组织节点信息列表，一个人可能属于多个组织节点，列表记录的都是最低级组织部门节点
        /// </summary>
        [XmlArray("node_info_list")]
        [XmlArrayItem("edu_node_info")]
        public List<EduNodeInfo> NodeInfoList { get; set; }

        /// <summary>
        /// 角色信息列表
        /// </summary>
        [XmlArray("role_info_list")]
        [XmlArrayItem("edu_role_info")]
        public List<EduRoleInfo> RoleInfoList { get; set; }

        /// <summary>
        /// 角色类型名称
        /// </summary>
        [XmlElement("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 花名册ID
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }
    }
}
