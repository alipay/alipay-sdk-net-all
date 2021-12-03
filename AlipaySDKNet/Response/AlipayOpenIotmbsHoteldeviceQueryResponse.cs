using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsHoteldeviceQueryResponse.
    /// </summary>
    public class AlipayOpenIotmbsHoteldeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 刷脸组ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 设备绑定的酒店名称
        /// </summary>
        [XmlElement("hotel_name")]
        public string HotelName { get; set; }

        /// <summary>
        /// 设备绑定的房间号
        /// </summary>
        [XmlElement("room_no")]
        public string RoomNo { get; set; }
    }
}
