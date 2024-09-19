using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPartnerQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoTravelPartnerQueryResponse : AopResponse
    {
        /// <summary>
        /// 伴游开启状态
        /// </summary>
        [XmlElement("assist_status")]
        public string AssistStatus { get; set; }

        /// <summary>
        /// 预计景点数
        /// </summary>
        [XmlElement("attractions_count")]
        public string AttractionsCount { get; set; }

        /// <summary>
        /// 预计消耗卡路里
        /// </summary>
        [XmlElement("calorie")]
        public string Calorie { get; set; }

        /// <summary>
        /// 当前POI景点信息
        /// </summary>
        [XmlElement("current_poi_info")]
        public PoiInfoVo CurrentPoiInfo { get; set; }

        /// <summary>
        /// 预计距离，单位米
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 预计游玩时长，单位小时
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 伴游记录id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 是否继续轮询（只有最新的&位置有效的要轮询）
        /// </summary>
        [XmlElement("need_poll")]
        public bool NeedPoll { get; set; }

        /// <summary>
        /// 下一个POI景点信息
        /// </summary>
        [XmlElement("next_poi_info")]
        public PoiInfoVo NextPoiInfo { get; set; }

        /// <summary>
        /// 下次轮询时间：秒
        /// </summary>
        [XmlElement("next_poll_interval")]
        public long NextPollInterval { get; set; }

        /// <summary>
        /// 是否偏离路线
        /// </summary>
        [XmlElement("off_route")]
        public bool OffRoute { get; set; }

        /// <summary>
        /// 每天途径的景点
        /// </summary>
        [XmlArray("poi_day_list")]
        [XmlArrayItem("poi_list_day_vo")]
        public List<PoiListDayVo> PoiDayList { get; set; }

        /// <summary>
        /// 路线起始点位
        /// </summary>
        [XmlElement("poly_line_point")]
        public string PolyLinePoint { get; set; }

        /// <summary>
        /// 地图的途径点位经纬度
        /// </summary>
        [XmlArray("polyline")]
        [XmlArrayItem("string")]
        public List<string> Polyline { get; set; }

        /// <summary>
        /// 路线包含的景点title
        /// </summary>
        [XmlArray("route_view_points")]
        [XmlArrayItem("string")]
        public List<string> RouteViewPoints { get; set; }

        /// <summary>
        /// 路线起始景点
        /// </summary>
        [XmlElement("start_point")]
        public PoiInfoVo StartPoint { get; set; }

        /// <summary>
        /// 预计台阶数
        /// </summary>
        [XmlElement("steps")]
        public string Steps { get; set; }

        /// <summary>
        /// 引导文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 路线名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 已经途经的景点
        /// </summary>
        [XmlArray("view_point")]
        [XmlArrayItem("string")]
        public List<string> ViewPoint { get; set; }

        /// <summary>
        /// cube卡片的路线封面图
        /// </summary>
        [XmlElement("view_point_image")]
        public string ViewPointImage { get; set; }
    }
}
