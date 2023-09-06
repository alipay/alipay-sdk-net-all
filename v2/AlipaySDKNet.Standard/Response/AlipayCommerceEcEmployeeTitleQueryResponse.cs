using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeTitleQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeTitleQueryResponse : AopResponse
    {
        /// <summary>
        /// 员工可用抬头信息列表
        /// </summary>
        [XmlElement("employee_title_list")]
        public EmployeeTitleInfoDTO EmployeeTitleList { get; set; }
    }
}
