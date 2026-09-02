using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsDepartBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsDepartBatchqueryModel : AopObject
    {
        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 父部门code
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }
    }
}
