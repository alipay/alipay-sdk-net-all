using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhiteCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsWhiteCreateModel : AopObject
    {
        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 花名册人员编码
        /// </summary>
        [XmlElement("roster_code")]
        public string RosterCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("white_type_list")]
        [XmlArrayItem("string")]
        public List<string> WhiteTypeList { get; set; }
    }
}
