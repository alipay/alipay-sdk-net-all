using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinSessionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FinSessionDetail : AopObject
    {
        /// <summary>
        /// 会话其他信息
        /// </summary>
        [XmlElement("additional_args")]
        public FinAdditionArgs AdditionalArgs { get; set; }

        /// <summary>
        /// 本次会话的主体ID
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 秒级别
        /// </summary>
        [XmlElement("last_active_time")]
        public string LastActiveTime { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 默认取最近一次用户query
        /// </summary>
        [XmlElement("session_title")]
        public string SessionTitle { get; set; }
    }
}
