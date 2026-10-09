using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicInfo : AopObject
    {
        /// <summary>
        /// 支付宝景区详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝景区市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 支付宝景区纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 支付宝维护的景区等级
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 支付宝景区经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 支付宝景区省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 支付宝景区ID
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 支付宝景区名称
        /// </summary>
        [XmlElement("scenic_name")]
        public string ScenicName { get; set; }

        /// <summary>
        /// 支付宝维护的景区电话，可能有多个电话号，以英文逗号分隔
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
