using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RouteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RouteInfo : AopObject
    {
        /// <summary>
        /// 伴游路线景点个数
        /// </summary>
        [XmlElement("attractions_count")]
        public string AttractionsCount { get; set; }

        /// <summary>
        /// 伴游路线距离，包含单位信息
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 伴游路线耗时，包含单位信息
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 伴游路线唯一id
        /// </summary>
        [XmlElement("route_id")]
        public string RouteId { get; set; }

        /// <summary>
        /// 伴游路线类别
        /// </summary>
        [XmlElement("route_type")]
        public string RouteType { get; set; }

        /// <summary>
        /// 伴游路线标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 伴游路线景点名称列表
        /// </summary>
        [XmlArray("view_point")]
        [XmlArrayItem("string")]
        public List<string> ViewPoint { get; set; }

        /// <summary>
        /// 伴游路线图片
        /// </summary>
        [XmlElement("view_point_image")]
        public string ViewPointImage { get; set; }
    }
}
