using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenEchoOfflineSendResponse.
    /// </summary>
    public class AlipayOpenEchoOfflineSendResponse : AopResponse
    {
        /// <summary>
        /// 10000
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
