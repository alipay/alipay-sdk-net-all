using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookingInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BookingInfoDTO : AopObject
    {
        /// <summary>
        /// 预约入住时间
        /// </summary>
        [XmlElement("booking_time")]
        public string BookingTime { get; set; }

        /// <summary>
        /// 入住日期
        /// </summary>
        [XmlElement("check_in_date")]
        public string CheckInDate { get; set; }

        /// <summary>
        /// 入住时间
        /// </summary>
        [XmlElement("check_in_time")]
        public string CheckInTime { get; set; }

        /// <summary>
        /// 离店日期
        /// </summary>
        [XmlElement("check_out_date")]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// 离店时间
        /// </summary>
        [XmlElement("check_out_time")]
        public string CheckOutTime { get; set; }

        /// <summary>
        /// 商户确认买家的预约
        /// </summary>
        [XmlElement("confirm_booking_time")]
        public string ConfirmBookingTime { get; set; }

        /// <summary>
        /// 客服电话，包含区号+电话号码的座机号码格式，以及手机号码格式。
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 最晚到店时间
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 商户为买家办理续住的时间
        /// </summary>
        [XmlElement("have_stay_time")]
        public string HaveStayTime { get; set; }

        /// <summary>
        /// 退改规则
        /// </summary>
        [XmlElement("refund_rule")]
        public string RefundRule { get; set; }

        /// <summary>
        /// 入住酒店房间号
        /// </summary>
        [XmlElement("room_num")]
        public string RoomNum { get; set; }
    }
}
