using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageCustomSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageCustomSendModel : AopObject
    {
        /// <summary>
        /// msg_type为image-text，本参数必填。 
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("article")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 是否为聊天消息。枚举支持： *0：代表非聊天消息，消息显示在生活号主页，默认为 0。 *1：代表是聊天消息，消息显示在咨询反馈列表页。
        /// </summary>
        [XmlElement("chat")]
        public string Chat { get; set; }

        /// <summary>
        /// 触发消息的事件类型，默认为空。代表商户未改造。如果是follow，代表关注消息。click代表菜单点击，enter_ppchat代表进入事件；请注意事件类型的大小写
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        ///  文本消息内容，当msg_type为text，本参数必填。 
        /// </summary>
        [XmlElement("text")]
        public Text Text { get; set; }

        /// <summary>
        /// 消息接收用户的userid
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
