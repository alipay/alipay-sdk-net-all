using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcShopInfo : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

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
        /// 一级mcc编码
        /// </summary>
        [XmlElement("mcc_code_1")]
        public string MccCode1 { get; set; }

        /// <summary>
        /// 二级mcc编码
        /// </summary>
        [XmlElement("mcc_code_2")]
        public string MccCode2 { get; set; }

        /// <summary>
        /// 一级mcc名称
        /// </summary>
        [XmlElement("mcc_name_1")]
        public string MccName1 { get; set; }

        /// <summary>
        /// 二级mcc名称
        /// </summary>
        [XmlElement("mcc_name_2")]
        public string MccName2 { get; set; }

        /// <summary>
        /// 门头照地址
        /// </summary>
        [XmlElement("outdoor_img_url")]
        public string OutdoorImgUrl { get; set; }

        /// <summary>
        /// 高德poiId
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
