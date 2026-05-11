using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelBasicinfoSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelBasicinfoSetModel : AopObject
    {
        /// <summary>
        /// 入住成功结果图片URL
        /// </summary>
        [XmlElement("checkin_success_image")]
        public string CheckinSuccessImage { get; set; }

        /// <summary>
        /// 是否启用会员功能
        /// </summary>
        [XmlElement("enable_member")]
        public string EnableMember { get; set; }

        /// <summary>
        /// 是否开启订单号查询：Y/N 默认是Y
        /// </summary>
        [XmlElement("enable_order_id_query")]
        public string EnableOrderIdQuery { get; set; }

        /// <summary>
        /// 是否开启手机号查询：Y/N,默认是Y
        /// </summary>
        [XmlElement("enable_phone_query")]
        public string EnablePhoneQuery { get; set; }

        /// <summary>
        /// 是否开启预定号查询Y/N 默认是N
        /// </summary>
        [XmlElement("enable_reservation_no_query")]
        public string EnableReservationNoQuery { get; set; }

        /// <summary>
        /// 酒店bian'm
        /// </summary>
        [XmlElement("hotel_code")]
        public string HotelCode { get; set; }

        /// <summary>
        /// 酒店描述
        /// </summary>
        [XmlElement("hotel_description")]
        public string HotelDescription { get; set; }

        /// <summary>
        /// 酒店集团code
        /// </summary>
        [XmlElement("hotel_group_code")]
        public string HotelGroupCode { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        [XmlElement("hotel_name")]
        public string HotelName { get; set; }

        /// <summary>
        /// 房卡制作图片链接，推荐大小570*503,已废弃
        /// </summary>
        [XmlElement("keycard_production_image")]
        public string KeycardProductionImage { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("registration_agreement")]
        [XmlArrayItem("string")]
        public List<string> RegistrationAgreement { get; set; }

        /// <summary>
        /// 会员注册提示
        /// </summary>
        [XmlElement("registration_sub_title")]
        public string RegistrationSubTitle { get; set; }

        /// <summary>
        /// 房间号样式类型
        /// </summary>
        [XmlElement("room_no_pattern_type")]
        public string RoomNoPatternType { get; set; }

        /// <summary>
        /// 酒店主题样式配置
        /// </summary>
        [XmlElement("theme")]
        public HotelThemeVO Theme { get; set; }
    }
}
