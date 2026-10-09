using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RemindPersonInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RemindPersonInfoDTO : AopObject
    {
        /// <summary>
        /// 通知渠道，包括邮件，短信，站内信，开放消息；开放消息不能与其他类型同处一个余额提醒中
        /// </summary>
        [XmlArray("channel_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelList { get; set; }

        /// <summary>
        /// 邮件提醒的接收邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 被提醒人电话
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 提醒人的姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
