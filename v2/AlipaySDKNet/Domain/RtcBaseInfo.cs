using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RtcBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RtcBaseInfo : AopObject
    {
        /// <summary>
        /// 频道ID
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("rtc_app_id")]
        public string RtcAppId { get; set; }

        /// <summary>
        /// rtc通信token值
        /// </summary>
        [XmlElement("rtc_token")]
        public string RtcToken { get; set; }

        /// <summary>
        /// RTC侧用户ID
        /// </summary>
        [XmlElement("rtc_user_id")]
        public string RtcUserId { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
