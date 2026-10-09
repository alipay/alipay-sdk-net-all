using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureEmployee Data Structure.
    /// </summary>
    [Serializable]
    public class InsureEmployee : AopObject
    {
        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型 10: 身份证 23:统一社会代码
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 零工卡卡号
        /// </summary>
        [XmlElement("employee_card_no")]
        public string EmployeeCardNo { get; set; }

        /// <summary>
        /// 员工工种code信息,按照文档附件规则传值
        /// </summary>
        [XmlElement("job")]
        public string Job { get; set; }

        /// <summary>
        /// 职业级别该字段废弃，只需要传工种job 当前字段已废弃(职业级别该字段废弃，只需要传工种job)
        /// </summary>
        [XmlElement("job_level")]
        public string JobLevel { get; set; }

        /// <summary>
        /// 外部员工id
        /// </summary>
        [XmlElement("out_employee_id")]
        public string OutEmployeeId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
