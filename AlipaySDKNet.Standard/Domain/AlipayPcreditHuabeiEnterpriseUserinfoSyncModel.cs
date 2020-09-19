using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseUserinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiEnterpriseUserinfoSyncModel : AopObject
    {
        /// <summary>
        /// 商务花呗用户协议id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 员工在支付宝的用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 员工所在部门名称
        /// </summary>
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 员工所在公司总人数
        /// </summary>
        [XmlElement("employee_count")]
        public string EmployeeCount { get; set; }

        /// <summary>
        /// 员工职级
        /// </summary>
        [XmlElement("employee_level")]
        public string EmployeeLevel { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工岗位
        /// </summary>
        [XmlElement("employee_position")]
        public string EmployeePosition { get; set; }

        /// <summary>
        /// 员工入职时间，精确到月份，yyyymm六位
        /// </summary>
        [XmlElement("entry_time")]
        public string EntryTime { get; set; }

        /// <summary>
        /// 员工身份证号（和员工手机号至少填写一个）
        /// </summary>
        [XmlElement("identity_no")]
        public string IdentityNo { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        [XmlElement("mail_addr")]
        public string MailAddr { get; set; }

        /// <summary>
        /// 员工是否管理岗，是管理岗传Y，非管理岗传N
        /// </summary>
        [XmlElement("management")]
        public string Management { get; set; }

        /// <summary>
        /// 员工手机号（和员工身份证号至少填写一个）
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 企业对应的支付宝商户Pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
