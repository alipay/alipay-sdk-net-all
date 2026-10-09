using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoomBatchCreateItem Data Structure.
    /// </summary>
    [Serializable]
    public class RoomBatchCreateItem : AopObject
    {
        /// <summary>
        /// 外部房间号,在房源提供方对户号的唯一标识
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 户主手机
        /// </summary>
        [XmlElement("owner_mobile")]
        public string OwnerMobile { get; set; }

        /// <summary>
        /// 户主姓名
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 房屋面积。默认单位: 平方米
        /// </summary>
        [XmlElement("room_area")]
        public string RoomArea { get; set; }

        /// <summary>
        /// 房间楼层
        /// </summary>
        [XmlElement("room_floor")]
        public string RoomFloor { get; set; }

        /// <summary>
        /// 房间
        /// </summary>
        [XmlElement("room_value")]
        public string RoomValue { get; set; }
    }
}
