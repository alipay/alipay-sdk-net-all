using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmSubscribe Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmSubscribe : AopObject
    {
        /// <summary>
        /// webhook/通知组ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 订阅ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 订阅类型
        /// </summary>
        [XmlArray("subscribe_types")]
        [XmlArrayItem("string")]
        public List<string> SubscribeTypes { get; set; }

        /// <summary>
        /// 订阅人(钉钉群聊机器人为绑定ID)
        /// </summary>
        [XmlElement("subscriber")]
        public string Subscriber { get; set; }
    }
}
