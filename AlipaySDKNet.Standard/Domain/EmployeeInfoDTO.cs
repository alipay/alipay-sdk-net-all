using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeInfoDTO : AopObject
    {
        /// <summary>
        /// 是否激活，可选值：ACTIVATED-已激活；UNACTIVATED-未激活；ACTIVATING-激活中
        /// </summary>
        [XmlElement("activate")]
        public string Activate { get; set; }

        /// <summary>
        /// 员工所属部门列表
        /// </summary>
        [XmlArray("department_list")]
        [XmlArrayItem("employee_department_d_t_o")]
        public List<EmployeeDepartmentDTO> DepartmentList { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 变更时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 变更时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 是否在库，0：在，1：不在
        /// </summary>
        [XmlElement("iot_face_status")]
        public string IotFaceStatus { get; set; }

        /// <summary>
        /// 员工在企业人脸库的人脸唯一标识
        /// </summary>
        [XmlElement("iot_vid")]
        public string IotVid { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 角色列表，可选值：USER-用户；ADMIM-管理员; SUPER_ADMIN-超级管理员; AGENCY_OPERATION - 代运营
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
