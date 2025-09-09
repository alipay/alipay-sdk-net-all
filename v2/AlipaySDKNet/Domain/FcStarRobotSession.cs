using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FcStarRobotSession Data Structure.
    /// </summary>
    [Serializable]
    public class FcStarRobotSession : AopObject
    {
        /// <summary>
        /// 会话结束时间戳（单位秒）
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 会话开始时间戳（单位秒）
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
