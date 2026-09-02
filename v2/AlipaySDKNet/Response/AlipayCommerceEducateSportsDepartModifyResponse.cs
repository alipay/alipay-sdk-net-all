using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsDepartModifyResponse : AopResponse
    {
        /// <summary>
        /// 部门主键code
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }
    }
}
