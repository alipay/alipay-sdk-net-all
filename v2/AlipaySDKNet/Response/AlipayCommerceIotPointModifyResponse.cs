using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotPointModifyResponse.
    /// </summary>
    public class AlipayCommerceIotPointModifyResponse : AopResponse
    {
        /// <summary>
        /// 点位ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
