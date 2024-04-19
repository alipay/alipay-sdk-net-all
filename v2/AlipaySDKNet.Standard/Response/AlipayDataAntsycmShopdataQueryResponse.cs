using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAntsycmShopdataQueryResponse.
    /// </summary>
    public class AlipayDataAntsycmShopdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁poi
        /// </summary>
        [XmlElement("ant_poi")]
        public string AntPoi { get; set; }

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
        /// 高德poi
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
        /// 省
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

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
        /// 门店得分结果
        /// </summary>
        [XmlElement("shop_score_result")]
        public ShopScoreResultInfoDTO ShopScoreResult { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
