using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsEmployee Data Structure.
    /// </summary>
    [Serializable]
    public class InsEmployee : AopObject
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
        /// 证件类型（数字字符串）, 10: 身份证 23:统一社会代码
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 员工工种信息
        /// </summary>
        [XmlElement("job")]
        public string Job { get; set; }

        /// <summary>
        /// 职业级别。 第一级：1 第二级：2 ...
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
