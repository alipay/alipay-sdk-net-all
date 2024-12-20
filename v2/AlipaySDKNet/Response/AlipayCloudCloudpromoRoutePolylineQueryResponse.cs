using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoRoutePolylineQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoRoutePolylineQueryResponse : AopResponse
    {
        /// <summary>
        /// 景点讲解文本
        /// </summary>
        [XmlElement("audio_text")]
        public string AudioText { get; set; }

        /// <summary>
        /// 景点图片链接
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 实时景点舒适度等级，无则为空
        /// </summary>
        [XmlElement("comfort_level")]
        public string ComfortLevel { get; set; }

        /// <summary>
        /// 景点的历史探索片段
        /// </summary>
        [XmlElement("historical_curiosities")]
        public string HistoricalCuriosities { get; set; }

        /// <summary>
        /// 一句话介绍
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// poi的id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 推荐的交通方式
        /// </summary>
        [XmlElement("line_type")]
        public string LineType { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 之间的路线点位
        /// </summary>
        [XmlArray("polyline")]
        [XmlArrayItem("string")]
        public List<string> Polyline { get; set; }

        /// <summary>
        /// 景点标签
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 景点名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 线路长度,单位米、千米
        /// </summary>
        [XmlElement("travel_distance")]
        public string TravelDistance { get; set; }

        /// <summary>
        /// 线路预计耗时，单位直接给出，分钟/小时/天
        /// </summary>
        [XmlElement("travel_duration")]
        public string TravelDuration { get; set; }
    }
}
