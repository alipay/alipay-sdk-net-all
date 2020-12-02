using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiverIstd Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiverIstd : AopObject
    {
        /// <summary>
        /// 地址(街道、小区、大厦等，用于定位)
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地址详情(楼号、单元号、层号)
        /// </summary>
        [XmlElement("address_detail")]
        public string AddressDetail { get; set; }

        /// <summary>
        /// 城市名称，如杭州市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 坐标类型，0：火星坐标（高德，腾讯地图均采用火星坐标） 1：百度坐标。目前只支持0:火星坐标
        /// </summary>
        [XmlElement("coordinate_type")]
        public long CoordinateType { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public long Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lng")]
        public long Lng { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
