using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsRosterModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsRosterModifyResponse : AopResponse
    {
        /// <summary>
        /// 花名册cod
        /// </summary>
        [XmlElement("roster_code")]
        public string RosterCode { get; set; }
    }
}
