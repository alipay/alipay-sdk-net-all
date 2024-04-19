using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgVO : AopObject
    {
        /// <summary>
        /// 图文消息内容
        /// </summary>
        [XmlElement("image_text_msg_content")]
        public ImageTextMsgVO ImageTextMsgContent { get; set; }

        /// <summary>
        /// 群消息类型枚举，图文消息"image-text"，小程序消息"tiny"。
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 小程序消息内容
        /// </summary>
        [XmlElement("tiny_app_msg_content")]
        public TinyAppMsgVO TinyAppMsgContent { get; set; }
    }
}
