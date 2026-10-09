using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotPointCreateResponse.
    /// </summary>
    public class AlipayCommerceIotPointCreateResponse : AopResponse
    {
        /// <summary>
        /// 点位ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
