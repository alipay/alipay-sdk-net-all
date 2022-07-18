using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcDepartmentInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceEcDepartmentInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 部门信息
        /// </summary>
        [XmlElement("department_info")]
        public DepartmentInfoDTO DepartmentInfo { get; set; }
    }
}
