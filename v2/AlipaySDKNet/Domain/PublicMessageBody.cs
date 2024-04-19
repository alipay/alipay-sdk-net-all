using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicMessageBody Data Structure.
    /// </summary>
    [Serializable]
    public class PublicMessageBody : AopObject
    {
        /// <summary>
        /// 图文消息，当msg_type为image-text，该值必须设置，图文消息中的图片建议尺寸 750 x 350px，小于3M，图片支持jpg、png格式
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("article")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 图文类型，目前只支持image-text 和 text
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 纯文字消息内容
        /// </summary>
        [XmlElement("text")]
        public TextContent Text { get; set; }
    }
}
