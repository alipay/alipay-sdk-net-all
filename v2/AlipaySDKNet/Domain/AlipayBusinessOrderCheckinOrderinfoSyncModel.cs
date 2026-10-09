using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessOrderCheckinOrderinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderCheckinOrderinfoSyncModel : AopObject
    {
        /// <summary>
        /// 酒店入住小程序
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 入住日期
        /// </summary>
        [XmlElement("check_in_date")]
        public string CheckInDate { get; set; }

        /// <summary>
        /// 系统入住时间
        /// </summary>
        [XmlElement("check_in_time")]
        public string CheckInTime { get; set; }

        /// <summary>
        /// 离店日期
        /// </summary>
        [XmlElement("check_out_date")]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// 系统离店时间
        /// </summary>
        [XmlElement("check_out_time")]
        public string CheckOutTime { get; set; }

        /// <summary>
        /// 扩展信息。回流的key值请提前联系支付宝侧人员配置，否则回流的key值不会被消费。
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 入住人姓名
        /// </summary>
        [XmlElement("guest_name")]
        public string GuestName { get; set; }

        /// <summary>
        /// 是否含早
        /// </summary>
        [XmlElement("has_breakfast")]
        public bool HasBreakfast { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        [XmlElement("hotel_name")]
        public string HotelName { get; set; }

        /// <summary>
        /// 用户会员等级
        /// </summary>
        [XmlElement("member_level")]
        public string MemberLevel { get; set; }

        /// <summary>
        /// open_id是用户（UserId）在应用（AppId）下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 入住订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 行业侧的订单id，该字段可选，具体描述分如下场景： 1.若订单是第一次同步，即新增场景，此时无需传该字段。订单同步成功后，在返回值中会将该字段给到isv。 2.若订单不是第一次同步，即更新场景，此时一定要传该字段。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源isv
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 订单状态。具体状态值如下： CHECK_IN  入住 CHECK_OUT 离店
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 入住订单更新时间
        /// </summary>
        [XmlElement("order_update_time")]
        public string OrderUpdateTime { get; set; }

        /// <summary>
        /// isv侧酒店id
        /// </summary>
        [XmlElement("outer_hotel_id")]
        public string OuterHotelId { get; set; }

        /// <summary>
        /// isv侧酒店入住单id
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 入住提醒点击的跳转链接。可以是小程序详情，但不能是订单详情。
        /// </summary>
        [XmlElement("remind_link")]
        public string RemindLink { get; set; }

        /// <summary>
        /// 酒店入住信息，包含房型信息和入住人。最大长度均限制为5，超出部分不会被消费。
        /// </summary>
        [XmlArray("room_info")]
        [XmlArrayItem("hotel_room_info")]
        public List<HotelRoomInfo> RoomInfo { get; set; }

        /// <summary>
        /// 入住人联系方式
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 入住人支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
