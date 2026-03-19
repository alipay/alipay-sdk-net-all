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
        /// 是否启用会员功能
        /// </summary>
        [XmlElement("enable_member")]
        public string EnableMember { get; set; }

        /// <summary>
        /// 酒店bian'm
        /// </summary>
        [XmlElement("hotel_code")]
        public string HotelCode { get; set; }

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
