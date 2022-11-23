using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeTitleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeTitleDTO : AopObject
    {
        /// <summary>
        /// 共同账户id,与enterprise_id两者必填其一
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("create_by")]
        public string CreateBy { get; set; }

        /// <summary>
        /// 企业域定义的员工id，与user_id两者必填其一
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业域定义的企业id，与account_id两者必填其一
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("modify_by")]
        public string ModifyBy { get; set; }

        /// <summary>
        /// 员工支付宝账号open_id,与employee_id两者必填其一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 抬头id
        /// </summary>
        [XmlElement("title_id")]
        public string TitleId { get; set; }

        /// <summary>
        /// 关系标记
        /// </summary>
        [XmlElement("title_tag")]
        public string TitleTag { get; set; }

        /// <summary>
        /// 员工支付宝账号2088,与employee_id两者必填其一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
