using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupmsgQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupmsgQueryResponse : AopResponse
    {
        /// <summary>
        /// 群消息发送详情
        /// </summary>
        [XmlElement("msg_send_detail")]
        public GroupMsgSendDetailVO MsgSendDetail { get; set; }
    }
}
