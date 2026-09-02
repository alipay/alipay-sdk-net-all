using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhiteDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsWhiteDeleteModel : AopObject
    {
        /// <summary>
        /// 学工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 白名单类型
        /// </summary>
        [XmlElement("white_type")]
        public string WhiteType { get; set; }
    }
}
