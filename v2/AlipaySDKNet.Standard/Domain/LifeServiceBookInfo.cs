using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceBookInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceBookInfo : AopObject
    {
        /// <summary>
        /// 预定id
        /// </summary>
        [XmlElement("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// 预定的包厢信息
        /// </summary>
        [XmlArray("room_infos")]
        [XmlArrayItem("life_service_room_info")]
        public List<LifeServiceRoomInfo> RoomInfos { get; set; }

        /// <summary>
        /// 预定的门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public LifeServiceShopInfo ShopInfo { get; set; }
    }
}
