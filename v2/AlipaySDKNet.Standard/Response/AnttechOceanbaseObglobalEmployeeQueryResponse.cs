using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalEmployeeQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalEmployeeQueryResponse : AopResponse
    {
        /// <summary>
        /// "用户部门"
        /// </summary>
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 用户部门编号
        /// </summary>
        [XmlElement("dept_no")]
        public string DeptNo { get; set; }

        /// <summary>
        /// "用户部门简称"
        /// </summary>
        [XmlElement("dept_short_name")]
        public string DeptShortName { get; set; }

        /// <summary>
        /// 用户email
        /// </summary>
        [XmlElement("email_addr")]
        public string EmailAddr { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 用户真名
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 用户花名
        /// </summary>
        [XmlElement("nick_name_cn")]
        public string NickNameCn { get; set; }

        /// <summary>
        /// "主管花名"
        /// </summary>
        [XmlElement("super_nick_name")]
        public string SuperNickName { get; set; }

        /// <summary>
        /// "主管工号"
        /// </summary>
        [XmlElement("super_work_no")]
        public string SuperWorkNo { get; set; }
    }
}
