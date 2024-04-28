using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddressInfoObj Data Structure.
    /// </summary>
    [Serializable]
    public class AddressInfoObj : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

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
        /// 用户姓名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

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
        /// 联系方式
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
