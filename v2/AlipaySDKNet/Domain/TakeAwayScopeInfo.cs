using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TakeAwayScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TakeAwayScopeInfo : AopObject
    {
        /// <summary>
        /// 圆形范围半径（单位公里），type为CIRCULAR时必填，circular_area与polygon_area二选一
        /// </summary>
        [XmlElement("circular_area")]
        public string CircularArea { get; set; }

        /// <summary>
        /// 服务商方提供的配送范围id。 如一个门店没有配送范围ID，可以填1。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 该配送区域的起送价
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 多边形范围，type为POLYGON时必填;["lon1;lat1","lon2;lat2","lon3;lat3"] 3个点<=每个多边形<10 ""中是多边形中的点，  ;分隔经纬度，
        /// </summary>
        [XmlArray("polygon_area")]
        [XmlArrayItem("string")]
        public List<string> PolygonArea { get; set; }

        /// <summary>
        /// 该配送区域的配送费
        /// </summary>
        [XmlElement("shipping_area")]
        public string ShippingArea { get; set; }

        /// <summary>
        /// 配置范围类型，枚举： POLYGON：表示配送范围由多边形组成 CIRCULAR：表示配送范围由圆形组成
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
