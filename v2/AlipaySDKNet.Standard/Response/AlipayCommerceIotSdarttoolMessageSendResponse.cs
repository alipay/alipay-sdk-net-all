using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageSendResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolMessageSendResponse : AopResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("message_no")]
        public string MessageNo { get; set; }
    }
}
