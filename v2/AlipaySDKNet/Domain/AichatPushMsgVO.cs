using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AichatPushMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class AichatPushMsgVO : AopObject
    {
        /// <summary>
        /// 待推送的消息内容
        /// </summary>
        [XmlElement("msg_content")]
        public string MsgContent { get; set; }

        /// <summary>
        /// 一个消息的唯一id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 智能体的小程序模版id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
