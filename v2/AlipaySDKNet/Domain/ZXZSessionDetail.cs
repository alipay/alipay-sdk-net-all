using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZXZSessionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ZXZSessionDetail : AopObject
    {
        /// <summary>
        /// 合作方用户标识
        /// </summary>
        [XmlElement("bu_unique_id")]
        public string BuUniqueId { get; set; }

        /// <summary>
        /// 时间戳，单位：S
        /// </summary>
        [XmlElement("last_activity_time")]
        public long LastActivityTime { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 这是会话标题，默认使用第一个问题作为会话标题，后续支持修改
        /// </summary>
        [XmlElement("session_title")]
        public string SessionTitle { get; set; }
    }
}
