using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeTitleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeTitleQueryModel : AopObject
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
        /// 抬头标识
        /// </summary>
        [XmlElement("title_tag")]
        public string TitleTag { get; set; }
    }
}
