using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusInstitutionsQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusInstitutionsQueryResponse : AopResponse
    {
        /// <summary>
        /// 学校简单信息列表
        /// </summary>
        [XmlElement("school_info")]
        public SchoolSimpleInfo SchoolInfo { get; set; }
    }
}
