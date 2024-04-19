using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MessageReceiveVO Data Structure.
    /// </summary>
    [Serializable]
    public class MessageReceiveVO : AopObject
    {
        /// <summary>
        /// 消息枚举
        /// </summary>
        [XmlElement("msg_enum")]
        public string MsgEnum { get; set; }

        /// <summary>
        /// 消息接收状态
        /// </summary>
        [XmlElement("msg_receive_state")]
        public bool MsgReceiveState { get; set; }
    }
}
