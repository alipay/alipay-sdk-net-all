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
        /// 是否激活
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
        /// 证件号，手机号，邮箱三个必填其一
        /// </summary>
        [XmlElement("employee_cert_no")]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 证件类型，当证件号不为空时必填
        /// </summary>
        [XmlElement("employee_cert_type")]
        public string EmployeeCertType { get; set; }

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
        /// 加密身份证号，当加密类型不为空时必填
        /// </summary>
        [XmlElement("encrypt_cert_no")]
        public string EncryptCertNo { get; set; }

        /// <summary>
        /// 加密手机号，当加密类型不为空时必填
        /// </summary>
        [XmlElement("encrypt_mobile")]
        public string EncryptMobile { get; set; }

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
        /// 员工是否人脸在库
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
        /// 角色列表
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
