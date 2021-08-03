using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityOwnercardmsgSyncResponse.
    /// </summary>
    public class AlipayEbppCommunityOwnercardmsgSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝消息id
        /// </summary>
        [XmlElement("alipay_msg_id")]
        public string AlipayMsgId { get; set; }
    }
}
