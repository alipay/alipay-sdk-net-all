using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RedPacketMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class RedPacketMsgVO : AopObject
    {
        /// <summary>
        /// 红包ID
        /// </summary>
        [XmlElement("red_packet_id")]
        public string RedPacketId { get; set; }
    }
}
