using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsRosterSaveResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsRosterSaveResponse : AopResponse
    {
        /// <summary>
        /// 新增成功的花名册code
        /// </summary>
        [XmlElement("roster_code")]
        public string RosterCode { get; set; }
    }
}
