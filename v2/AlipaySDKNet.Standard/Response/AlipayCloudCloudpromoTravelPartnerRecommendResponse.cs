using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPartnerRecommendResponse.
    /// </summary>
    public class AlipayCloudCloudpromoTravelPartnerRecommendResponse : AopResponse
    {
        /// <summary>
        /// 来源为智能体则给出智能体id，用于后续查询交互
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 伴游状态，WAITING("WAITING", "等待开启", "伴游中"),OPEN("OPEN", "开启", "伴游中"), STOP("STOP", "停止", "随心游暂停-可重新开启")
        /// </summary>
        [XmlElement("assist_status")]
        public string AssistStatus { get; set; }

        /// <summary>
        /// 实时景点舒适度等级，无则为空
        /// </summary>
        [XmlElement("comfort_level")]
        public string ComfortLevel { get; set; }

        /// <summary>
        /// 已游玩景点个数
        /// </summary>
        [XmlElement("current_attraction_count")]
        public string CurrentAttractionCount { get; set; }

        /// <summary>
        /// 已游玩距离，单位米、千米，已给出
        /// </summary>
        [XmlElement("current_distance")]
        public string CurrentDistance { get; set; }

        /// <summary>
        /// 已游玩耗时，单位分钟、小时、天
        /// </summary>
        [XmlElement("current_duration")]
        public string CurrentDuration { get; set; }

        /// <summary>
        /// 当前所在POI景点信息，没有则为空
        /// </summary>
        [XmlElement("current_poi_info")]
        public PoiInfoVo CurrentPoiInfo { get; set; }

        /// <summary>
        /// 是否在景区AOI范围内
        /// </summary>
        [XmlElement("if_aoi_range")]
        public bool IfAoiRange { get; set; }

        /// <summary>
        /// 随心游卡片记录唯一id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 基于当前位置附近范围的景点列表，根据lbs动态刷新的
        /// </summary>
        [XmlArray("nearby_poi_list")]
        [XmlArrayItem("poi_info_vo")]
        public List<PoiInfoVo> NearbyPoiList { get; set; }

        /// <summary>
        /// 是否继续轮询（只有最新的随心游卡片要轮询）
        /// </summary>
        [XmlElement("need_poll")]
        public bool NeedPoll { get; set; }

        /// <summary>
        /// [{"latitude":"30.140215","lineType":"步行","longitude":"118.161578","tags":"热门景点","title":"排云亭","travelDistance":"192.11千米","travelDuration":"3时1分"},{"latitude":"30.135591","longitude":"118.163971","tags":"必玩景点","title":"飞来石"}]
        /// </summary>
        [XmlArray("next_nearest_poi_list")]
        [XmlArrayItem("poi_info_vo")]
        public List<PoiInfoVo> NextNearestPoiList { get; set; }

        /// <summary>
        /// 已途径的路线经纬度点位
        /// </summary>
        [XmlArray("polyline")]
        [XmlArrayItem("string")]
        public List<string> Polyline { get; set; }

        /// <summary>
        /// 推荐文字，例如当前正在游览【迎客松】和下一站建议游玩【迎客松】
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
