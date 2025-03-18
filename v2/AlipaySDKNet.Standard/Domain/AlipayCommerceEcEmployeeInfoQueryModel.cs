using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeInfoQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝登录号（手机号或邮箱）
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 员工证件号码
        /// </summary>
        [XmlElement("employee_cert_no")]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 员工证件类型
        /// </summary>
        [XmlElement("employee_cert_type")]
        public string EmployeeCertType { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        [XmlElement("employee_email")]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 员工手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
