using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsDepartModifyModel : AopObject
    {
        /// <summary>
        /// 部门主键code，用于定位被修改的部门
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }
    }
}
