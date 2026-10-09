using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipmcMetaqMessageOpenMqDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AlipmcMetaqMessageOpenMqDTO : AopObject
    {
        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("alipmc_message_id")]
        public string AlipmcMessageId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("body")]
        public AlipmcMetaqMessageOpenMqBody Body { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("message_timestamp")]
        public string MessageTimestamp { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }
    }
}
