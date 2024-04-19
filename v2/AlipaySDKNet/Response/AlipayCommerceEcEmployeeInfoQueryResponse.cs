using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 员工信息
        /// </summary>
        [XmlElement("employee_info")]
        public EmployeeInfoDTO EmployeeInfo { get; set; }
    }
}
