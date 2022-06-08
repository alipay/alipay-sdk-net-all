using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsHoteldeviceQueryResponse.
    /// </summary>
    public class AlipayOpenIotmbsHoteldeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备绑定的人脸数据列表
        /// </summary>
        [XmlArray("face_list")]
        [XmlArrayItem("hotel_room_face_info_res")]
        public List<HotelRoomFaceInfoRes> FaceList { get; set; }

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

        /// <summary>
        /// 0:未入住，1:入住
        /// </summary>
        [XmlElement("room_status")]
        public string RoomStatus { get; set; }
    }
}
