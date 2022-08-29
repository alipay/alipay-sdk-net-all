using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeDeleteModel : AopObject
    {
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
    }
}
