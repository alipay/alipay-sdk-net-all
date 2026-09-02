using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsDepartDeleteModel : AopObject
    {
        /// <summary>
        /// 部门主键code，用于定位被删除的部门
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }
    }
}
