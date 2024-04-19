using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAntsycmShopdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAntsycmShopdataQueryModel : AopObject
    {
        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("account_pid")]
        public string AccountPid { get; set; }

        /// <summary>
        /// 蚂蚁POI，有则传，用于精准匹配
        /// </summary>
        [XmlElement("ant_poi")]
        public string AntPoi { get; set; }

        /// <summary>
        /// 商户授权码
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

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
        /// 高德poi，有则传，用于精准匹配
        /// </summary>
        [XmlElement("gaode_poi")]
        public string GaodePoi { get; set; }

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
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

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
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
