using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizUnit Data Structure.
    /// </summary>
    [Serializable]
    public class BizUnit : AopObject
    {
        /// <summary>
        /// 高德POIId
        /// </summary>
        [XmlElement("amap_id")]
        public string AmapId { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("biz_address")]
        public string BizAddress { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("biz_city_code")]
        public string BizCityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("biz_city_name")]
        public string BizCityName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("biz_latitude")]
        public string BizLatitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("biz_longitude")]
        public string BizLongitude { get; set; }

        /// <summary>
        /// 省份code
        /// </summary>
        [XmlElement("biz_province_code")]
        public string BizProvinceCode { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("biz_province_name")]
        public string BizProvinceName { get; set; }

        /// <summary>
        /// 区县code
        /// </summary>
        [XmlElement("biz_region_code")]
        public string BizRegionCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("biz_region_name")]
        public string BizRegionName { get; set; }

        /// <summary>
        /// 主体单元id，如社区id等
        /// </summary>
        [XmlElement("biz_unit_id")]
        public string BizUnitId { get; set; }

        /// <summary>
        /// 主体单元名称，如社区名称
        /// </summary>
        [XmlElement("biz_unit_name")]
        public string BizUnitName { get; set; }
    }
}
