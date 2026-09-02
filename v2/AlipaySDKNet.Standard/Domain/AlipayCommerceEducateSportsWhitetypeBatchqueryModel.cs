using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhitetypeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsWhitetypeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }
    }
}
