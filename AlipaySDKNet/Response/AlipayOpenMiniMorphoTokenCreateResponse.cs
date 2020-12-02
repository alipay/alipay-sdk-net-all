using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMorphoTokenCreateResponse.
    /// </summary>
    public class AlipayOpenMiniMorphoTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 闪蝶 SDK Token
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
