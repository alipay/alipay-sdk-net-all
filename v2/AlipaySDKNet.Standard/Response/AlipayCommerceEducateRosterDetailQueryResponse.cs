using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateRosterDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateRosterDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 花名册是否绑定支付宝
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
        /// 部门信息
        /// </summary>
        [XmlArray("department_info")]
        [XmlArrayItem("edu_department_node")]
        public List<EduDepartmentNode> DepartmentInfo { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 学工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 过期失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 机构ID
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
        /// 所属组织节点列表
        /// </summary>
        [XmlArray("node_info_list")]
        [XmlArrayItem("edu_node_info")]
        public List<EduNodeInfo> NodeInfoList { get; set; }

        /// <summary>
        /// 所属位置列表
        /// </summary>
        [XmlArray("place_info_list")]
        [XmlArrayItem("edu_place_info")]
        public List<EduPlaceInfo> PlaceInfoList { get; set; }

        /// <summary>
        /// 所属角色列表
        /// </summary>
        [XmlArray("role_info_list")]
        [XmlArrayItem("edu_role_info")]
        public List<EduRoleInfo> RoleInfoList { get; set; }

        /// <summary>
        /// 角色名称，可自定义，未自定义则使用默认值
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
