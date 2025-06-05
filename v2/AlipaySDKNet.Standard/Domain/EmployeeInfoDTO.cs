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
        /// 员工所属核算主体列表
        /// </summary>
        [XmlArray("accounting_entity_list")]
        [XmlArrayItem("employee_accounting_entity_d_t_o")]
        public List<EmployeeAccountingEntityDTO> AccountingEntityList { get; set; }

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
        /// 员工邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("employee_cert_no")]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 证件类型
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
        /// 员工编号/工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 加密证件号（证件号转大写后使用SHA256加密），搭配证件号使用
        /// </summary>
        [XmlElement("encrypt_cert_no")]
        public string EncryptCertNo { get; set; }

        /// <summary>
        /// 加密手机号（使用SHA256进行加密）
        /// </summary>
        [XmlElement("encrypt_mobile")]
        public string EncryptMobile { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 变更时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 员工收票邮箱
        /// </summary>
        [XmlElement("invoice_email")]
        public string InvoiceEmail { get; set; }

        /// <summary>
        /// 员工是否人脸在库
        /// </summary>
        [XmlElement("iot_face_status")]
        public string IotFaceStatus { get; set; }

        /// <summary>
        /// IOT开通刷脸支持唯一操作流水号，此处透出用于外部服务商通过该unique_id便捷调用IOT侧接口
        /// </summary>
        [XmlElement("iot_unique_id")]
        public string IotUniqueId { get; set; }

        /// <summary>
        /// 员工在企业人脸库的人脸唯一标识
        /// </summary>
        [XmlElement("iot_vid")]
        public string IotVid { get; set; }

        /// <summary>
        /// 员工职级
        /// </summary>
        [XmlElement("job_level_show")]
        public string JobLevelShow { get; set; }

        /// <summary>
        /// 员工标签
        /// </summary>
        [XmlArray("label_names")]
        [XmlArrayItem("string")]
        public List<string> LabelNames { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户ID（绑定支付宝账号的uid）
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 个性化信息 <a href='https://opendocs.alipay.com/pre-open/0ceh47?pathHash=14fac87c'>详见文档</a>
        /// </summary>
        [XmlElement("profiles")]
        public string Profiles { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }

        /// <summary>
        /// 直属主管员工ID
        /// </summary>
        [XmlElement("tl_employee_id")]
        public string TlEmployeeId { get; set; }

        /// <summary>
        /// 用户ID（绑定支付宝账号的uid）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
