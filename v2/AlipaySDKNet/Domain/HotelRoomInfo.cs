using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelRoomInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HotelRoomInfo : AopObject
    {
        /// <summary>
        /// 酒店入住人信息
        /// </summary>
        [XmlArray("guests")]
        [XmlArrayItem("hotel_guests")]
        public List<HotelGuests> Guests { get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        [XmlElement("room_number")]
        public string RoomNumber { get; set; }

        /// <summary>
        /// 房型
        /// </summary>
        [XmlElement("room_type")]
        public string RoomType { get; set; }
    }
}
