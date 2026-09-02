using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsDepartCreateModel : AopObject
    {
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

        /// <summary>
        /// 父级部门code，添加一级部门时传organization_code
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }
    }
}
