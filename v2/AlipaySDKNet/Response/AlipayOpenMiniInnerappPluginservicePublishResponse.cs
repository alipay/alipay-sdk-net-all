using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginservicePublishResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappPluginservicePublishResponse : AopResponse
    {
        /// <summary>
        /// PL2012211102012056
        /// </summary>
        [XmlElement("ability_id")]
        public string AbilityId { get; set; }
    }
}
