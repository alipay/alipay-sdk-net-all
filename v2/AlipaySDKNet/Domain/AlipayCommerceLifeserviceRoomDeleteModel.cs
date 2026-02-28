using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceRoomDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceRoomDeleteModel : AopObject
    {
        /// <summary>
        /// 三方场地id【需保证唯一性】
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 场地id【和out_room_id二选一】
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
