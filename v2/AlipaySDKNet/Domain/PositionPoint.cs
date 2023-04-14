using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PositionPoint Data Structure.
    /// </summary>
    [Serializable]
    public class PositionPoint : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 位置点维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 位置点经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 位置点订单数
        /// </summary>
        [XmlElement("order_count")]
        public string OrderCount { get; set; }

        /// <summary>
        /// 位置点半径
        /// </summary>
        [XmlElement("radius")]
        public string Radius { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 位置点出租车数
        /// </summary>
        [XmlElement("taxi_count")]
        public string TaxiCount { get; set; }
    }
}
