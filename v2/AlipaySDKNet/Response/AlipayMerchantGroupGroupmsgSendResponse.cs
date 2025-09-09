using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupmsgSendResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupmsgSendResponse : AopResponse
    {
        /// <summary>
        /// msg_id消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
