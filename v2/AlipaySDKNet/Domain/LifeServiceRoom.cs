using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceRoom Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceRoom : AopObject
    {
        /// <summary>
        /// 三方场地id
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("room_attrs")]
        [XmlArrayItem("life_service_attr")]
        public List<LifeServiceAttr> RoomAttrs { get; set; }

        /// <summary>
        /// 场地种类
        /// </summary>
        [XmlElement("room_category")]
        public string RoomCategory { get; set; }

        /// <summary>
        /// 场地id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 棋牌室、ktv包厢，运动场馆场地等名称
        /// </summary>
        [XmlElement("room_name")]
        public string RoomName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("room_pics")]
        [XmlArrayItem("string")]
        public List<string> RoomPics { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// active 可预约状态 inactive 不可预约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
