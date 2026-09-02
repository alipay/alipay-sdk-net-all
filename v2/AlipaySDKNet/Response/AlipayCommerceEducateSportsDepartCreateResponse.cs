using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsDepartCreateResponse : AopResponse
    {
        /// <summary>
        /// 部门编码
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }
    }
}
