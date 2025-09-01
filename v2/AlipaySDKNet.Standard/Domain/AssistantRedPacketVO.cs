using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantRedPacketVO Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantRedPacketVO : AopObject
    {
        /// <summary>
        /// 用于填写红包id
        /// </summary>
        [XmlElement("red_packet_id")]
        public string RedPacketId { get; set; }

        /// <summary>
        /// 红包可见的棋盘人群
        /// </summary>
        [XmlElement("visible_users")]
        public string VisibleUsers { get; set; }
    }
}
