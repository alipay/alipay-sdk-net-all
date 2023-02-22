using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTestTestChargeResponse.
    /// </summary>
    public class AlipayOpenAppTestTestChargeResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
