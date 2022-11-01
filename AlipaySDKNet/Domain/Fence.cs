using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Fence Data Structure.
    /// </summary>
    [Serializable]
    public class Fence : AopObject
    {
        /// <summary>
        /// 格子内部ID
        /// </summary>
        [XmlElement("grid_id")]
        public string GridId { get; set; }

        /// <summary>
        /// 格子外部ID
        /// </summary>
        [XmlElement("hex_id")]
        public string HexId { get; set; }

        /// <summary>
        /// 订单数
        /// </summary>
        [XmlElement("order_count")]
        public string OrderCount { get; set; }

        /// <summary>
        /// 热力图坐标列表由7个坐标点组成，包括一个中心点和六边形的六个顶点，可绘制出一个热力图六边形
        /// </summary>
        [XmlArray("points")]
        [XmlArrayItem("fence_point")]
        public List<FencePoint> Points { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("rank")]
        public string Rank { get; set; }
    }
}
