using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmEpBusinessLocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmEpBusinessLocationInfo : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

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
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 置信度。 0-经高德poi/交易定位双重验证   1-经高德poi验证 2-经交易定位验证 3-企业工商年报公布地址
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
