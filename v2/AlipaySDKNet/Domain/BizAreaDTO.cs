using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizAreaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BizAreaDTO : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 商圈码
        /// </summary>
        [XmlElement("biz_area_code")]
        public string BizAreaCode { get; set; }

        /// <summary>
        /// 商圈英文名称
        /// </summary>
        [XmlElement("biz_area_english_name")]
        public string BizAreaEnglishName { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [XmlElement("biz_area_name")]
        public string BizAreaName { get; set; }

        /// <summary>
        /// 商圈类型
        /// </summary>
        [XmlElement("biz_area_type")]
        public string BizAreaType { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("biz_area_version")]
        public long BizAreaVersion { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 商圈围栏
        /// </summary>
        [XmlElement("coords")]
        public string Coords { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 国家名
        /// </summary>
        [XmlElement("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 包括标签，黑名单，图片。本次不包含经纬度了
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 全球眼商圈编码
        /// </summary>
        [XmlElement("ge_biz_area_code")]
        public string GeBizAreaCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 商圈logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 花名加员工id
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// VALID INVALID
        /// </summary>
        [XmlElement("origin_flag")]
        public string OriginFlag { get; set; }

        /// <summary>
        /// 商店数量
        /// </summary>
        [XmlElement("shop_count")]
        public string ShopCount { get; set; }

        /// <summary>
        /// 商圈业务名称
        /// </summary>
        [XmlElement("show_name")]
        public string ShowName { get; set; }

        /// <summary>
        /// ON OFF CONTROLLED_ON
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
