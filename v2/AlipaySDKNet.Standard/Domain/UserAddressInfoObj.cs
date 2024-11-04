using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserAddressInfoObj Data Structure.
    /// </summary>
    [Serializable]
    public class UserAddressInfoObj : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 当同一类型地址在数组中时（如拉货服务多个途经点地址），用来标明地址顺序
        /// </summary>
        [XmlElement("address_order")]
        public string AddressOrder { get; set; }

        /// <summary>
        /// 区/县
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 楼梯层数
        /// </summary>
        [XmlElement("floor_height")]
        public string FloorHeight { get; set; }

        /// <summary>
        /// 楼梯类型
        /// </summary>
        [XmlElement("floor_type")]
        public string FloorType { get; set; }

        /// <summary>
        /// 门牌号
        /// </summary>
        [XmlElement("house_number")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// poi地点名称
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
