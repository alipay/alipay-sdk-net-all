using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HotelInfo : AopObject
    {
        /// <summary>
        /// 酒店品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 酒店地址
        /// </summary>
        [XmlElement("hotel_address")]
        public string HotelAddress { get; set; }

        /// <summary>
        /// 酒店可以入住时间
        /// </summary>
        [XmlElement("hotel_check_in_time")]
        public string HotelCheckInTime { get; set; }

        /// <summary>
        /// 酒店离店时间
        /// </summary>
        [XmlElement("hotel_check_out_time")]
        public string HotelCheckOutTime { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        [XmlElement("hotel_name")]
        public string HotelName { get; set; }

        /// <summary>
        /// 高德坐标系下的纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 高德坐标系下的经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 身份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 支付宝域店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
