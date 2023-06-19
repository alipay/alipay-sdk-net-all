using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeAddModel : AopObject
    {
        /// <summary>
        /// 员工所属部门
        /// </summary>
        [XmlArray("department_ids")]
        [XmlArrayItem("string")]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 证件号码，根据employee_cert_type指定的证件类型，传入对应的证件号码，用于企业人脸库员工刷脸开通时的核验。
        /// </summary>
        [XmlElement("employee_cert_no")]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 证件类型，用于企业人脸库员工刷脸开通时的核验
        /// </summary>
        [XmlElement("employee_cert_type")]
        public string EmployeeCertType { get; set; }

        /// <summary>
        /// 员工邮箱；手机号、邮箱、identity_type三个属性至少传入一个
        /// </summary>
        [XmlElement("employee_email")]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工手机号；手机号、邮箱、identity_type三个属性至少传入一个
        /// </summary>
        [XmlElement("employee_mobile")]
        public string EmployeeMobile { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 根据identity_type指定的身份类型，传入对应的身份标识，企业支付宝登录账号(支持手机号或者邮箱)或企业支付宝会员id(对应2088开头的支付宝会员id)
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 当identity_type为ALIPAY_USER_ID时，此字段传入open_id
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 身份类型；手机号、邮箱、identity_type三个属性至少传入一个
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 员工刷脸加入企业人脸库时的核验方式，如果设置为business_facepay_checkall，则employee_name、employee_cert_type、employee_cert_no必传，如果不传则默认不核验。
        /// </summary>
        [XmlElement("iot_check_type")]
        public string IotCheckType { get; set; }

        /// <summary>
        /// 员工在企业人脸库的人脸唯一标识（该字段已作废，不支持自定义传入）
        /// </summary>
        [XmlElement("iot_vid")]
        public string IotVid { get; set; }

        /// <summary>
        /// 角色列表，目前只支持填一种角色，默认为USER
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }
    }
}
