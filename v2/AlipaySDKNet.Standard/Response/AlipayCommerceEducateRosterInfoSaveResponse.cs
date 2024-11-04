using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateRosterInfoSaveResponse.
    /// </summary>
    public class AlipayCommerceEducateRosterInfoSaveResponse : AopResponse
    {
        /// <summary>
        /// 花名册ID
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }
    }
}
