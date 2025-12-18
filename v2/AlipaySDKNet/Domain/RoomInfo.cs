using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoomInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoomInfo : AopObject
    {
        /// <summary>
        /// 房型详细信息
        /// </summary>
        [XmlElement("room_detail")]
        public RoomDetailInfo RoomDetail { get; set; }

        /// <summary>
        /// 支付宝聚合房型id，有效正整数
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 酒店的房间名称
        /// </summary>
        [XmlElement("room_name")]
        public string RoomName { get; set; }
    }
}
