using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageTotalSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageTotalSendModel : AopObject
    {
        /// <summary>
        /// 图文消息，当 msg_type为image-text，本参数必填。 
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("article")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 当msg_type为text，本参数必填。
        /// </summary>
        [XmlElement("text")]
        public Text Text { get; set; }
    }
}
