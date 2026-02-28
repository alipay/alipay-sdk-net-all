using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceRoomInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceRoomInfo : AopObject
    {
        /// <summary>
        /// 预定结束时间
        /// </summary>
        [XmlElement("book_end_time")]
        public string BookEndTime { get; set; }

        /// <summary>
        /// 预定开始时间
        /// </summary>
        [XmlElement("book_start_time")]
        public string BookStartTime { get; set; }

        /// <summary>
        /// 包厢id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 包厢名称
        /// </summary>
        [XmlElement("room_name")]
        public string RoomName { get; set; }
    }
}
