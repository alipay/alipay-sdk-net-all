using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AirticketPriceQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AirticketPriceQueryInfo : AopObject
    {
        /// <summary>
        /// 到达城市三字码
        /// </summary>
        [XmlElement("arr_city_code")]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// 出发城市三字码
        /// </summary>
        [XmlElement("dep_city_code")]
        public string DepCityCode { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        [XmlElement("dep_date")]
        public string DepDate { get; set; }

        /// <summary>
        /// 票面航班号
        /// </summary>
        [XmlArray("flight_no")]
        [XmlArrayItem("string")]
        public List<string> FlightNo { get; set; }

        /// <summary>
        /// 是否最低价
        /// </summary>
        [XmlElement("has_lowest")]
        public bool HasLowest { get; set; }

        /// <summary>
        /// 是否中转
        /// </summary>
        [XmlElement("has_transfer")]
        public bool HasTransfer { get; set; }

        /// <summary>
        /// 最低价格
        /// </summary>
        [XmlElement("lowest_price")]
        public string LowestPrice { get; set; }

        /// <summary>
        /// 中转城市三字码
        /// </summary>
        [XmlElement("transit_city_code")]
        public string TransitCityCode { get; set; }
    }
}
