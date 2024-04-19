using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateYouthEdumessageauthQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateYouthEdumessageauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户授权状态
        /// </summary>
        [XmlElement("inst_auth_state")]
        public bool InstAuthState { get; set; }

        /// <summary>
        /// 消息接收状态
        /// </summary>
        [XmlElement("message_receive_state_list")]
        public MessageReceiveVO MessageReceiveStateList { get; set; }
    }
}
