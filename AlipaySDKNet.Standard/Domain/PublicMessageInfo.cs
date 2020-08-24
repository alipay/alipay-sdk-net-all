using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicMessageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PublicMessageInfo : AopObject
    {
        /// <summary>
        /// 内容信息
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("image_text_item")]
        public List<ImageTextItem> Articles { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 发送状态。INIT：未开始发送、RUNNING：发送中、SUCCESS：发送成功、FAILURE：发送失败、RECALLING：撤回中、RECALLED：撤回失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 消息状态：未开始发送、发送失败、正在处理中、撤回中、撤回成功、发送成功
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }
    }
}
