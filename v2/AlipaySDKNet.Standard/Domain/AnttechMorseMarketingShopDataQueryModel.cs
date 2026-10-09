using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingShopDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingShopDataQueryModel : AopObject
    {
        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("account_pid")]
        public string AccountPid { get; set; }

        /// <summary>
        /// 商户授权码
        /// </summary>
        [XmlElement("bussiness_code")]
        public string BussinessCode { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("county_name")]
        public string CountyName { get; set; }

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
        /// 高德poi或蚂蚁poi等，有则传，用于精准匹配，可扩展其他poi
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 获取分数类型
        /// </summary>
        [XmlArray("score_type")]
        [XmlArrayItem("string")]
        public List<string> ScoreType { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
