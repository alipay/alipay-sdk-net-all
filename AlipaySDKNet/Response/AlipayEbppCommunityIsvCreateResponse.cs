using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityIsvCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityIsvCreateResponse : AopResponse
    {
        /// <summary>
        /// ISV短名
        /// </summary>
        [XmlElement("isv_short_name")]
        public string IsvShortName { get; set; }
    }
}
