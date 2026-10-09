using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcEmployeeTitleFailed Data Structure.
    /// </summary>
    [Serializable]
    public class EcEmployeeTitleFailed : AopObject
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 返回每一个抬头批量处理信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 抬头ID
        /// </summary>
        [XmlElement("title_id")]
        public string TitleId { get; set; }

        /// <summary>
        /// 标识抬头是否默认DEFAULT/多抬头MULTI
        /// </summary>
        [XmlElement("title_tag")]
        public string TitleTag { get; set; }
    }
}
