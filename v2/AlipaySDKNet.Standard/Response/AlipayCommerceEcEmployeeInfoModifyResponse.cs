using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInfoModifyResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeInfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }
    }
}
