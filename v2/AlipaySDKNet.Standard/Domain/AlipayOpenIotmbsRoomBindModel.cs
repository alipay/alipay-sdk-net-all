using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsRoomBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsRoomBindModel : AopObject
    {
        /// <summary>
        /// 设备激活编号
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 设备类型，1:房间设备，2:前台设备
        /// </summary>
        [XmlElement("device_type")]
        public long DeviceType { get; set; }

        /// <summary>
        /// 楼层号
        /// </summary>
        [XmlElement("floor_num")]
        public string FloorNum { get; set; }

        /// <summary>
        /// 酒店编号
        /// </summary>
        [XmlElement("hotel_id")]
        public string HotelId { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        [XmlElement("hotel_name")]
        public string HotelName { get; set; }

        /// <summary>
        /// 项目ID，目前涂鸦这边是用酒店ID做项目ID来隔离
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 酒店的房间编号
        /// </summary>
        [XmlElement("room_no")]
        public string RoomNo { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
