using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyBizData Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyBizData : AopObject
    {
        /// <summary>
        /// 渠道用户标识
        /// </summary>
        [XmlElement("channel_user_tag")]
        public string ChannelUserTag { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("entrance")]
        public string Entrance { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
