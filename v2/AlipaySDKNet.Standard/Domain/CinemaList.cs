using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CinemaList Data Structure.
    /// </summary>
    [Serializable]
    public class CinemaList : AopObject
    {
        /// <summary>
        /// 影城地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 影城编码
        /// </summary>
        [XmlElement("cinema_code")]
        public string CinemaCode { get; set; }

        /// <summary>
        /// 离我当前的距离, 单位米
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 影城 id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 纬度(百度坐标)
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("lowest_price")]
        public string LowestPrice { get; set; }

        /// <summary>
        /// 市场价格
        /// </summary>
        [XmlElement("market_price")]
        public string MarketPrice { get; set; }

        /// <summary>
        /// 排期时间列表
        /// </summary>
        [XmlArray("near_future")]
        [XmlArrayItem("array_list")]
        public List<ArrayList> NearFuture { get; set; }
    }
}
