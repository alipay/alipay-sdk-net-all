using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotPointDeleteResponse.
    /// </summary>
    public class AlipayCommerceIotPointDeleteResponse : AopResponse
    {
        /// <summary>
        /// 点位ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
