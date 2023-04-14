using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Room Data Structure.
    /// </summary>
    [Serializable]
    public class Room : AopObject
    {
        /// <summary>
        /// 出行人信息
        /// </summary>
        [XmlArray("guests")]
        [XmlArrayItem("passenger")]
        public List<Passenger> Guests { get; set; }

        /// <summary>
        /// 房型
        /// </summary>
        [XmlElement("room_type")]
        public string RoomType { get; set; }
    }
}
