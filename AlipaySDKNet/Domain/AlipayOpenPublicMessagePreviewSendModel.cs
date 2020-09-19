using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessagePreviewSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessagePreviewSendModel : AopObject
    {
        /// <summary>
        /// 预览用户登录id列表，每次做多发送5个用户，且这5个用户必须是生活号的管理员或者是操作员,
        /// </summary>
        [XmlArray("logon_ids")]
        [XmlArrayItem("string")]
        public List<string> LogonIds { get; set; }

        /// <summary>
        /// 推送的消息体信息
        /// </summary>
        [XmlElement("msg_body")]
        public PublicMessageBody MsgBody { get; set; }
    }
}
