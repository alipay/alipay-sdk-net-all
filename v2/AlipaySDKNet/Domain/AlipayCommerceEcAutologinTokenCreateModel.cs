using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAutologinTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAutologinTokenCreateModel : AopObject
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
    }
}
