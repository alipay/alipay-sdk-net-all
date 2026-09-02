using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartDeleteResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsDepartDeleteResponse : AopResponse
    {
        /// <summary>
        /// 部门主键code，用于定位被删除的部门
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }
    }
}
