using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoiInfoVo Data Structure.
    /// </summary>
    [Serializable]
    public class PoiInfoVo : AopObject
    {
        /// <summary>
        /// 景点详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 音频文本
        /// </summary>
        [XmlElement("audio_text")]
        public string AudioText { get; set; }

        /// <summary>
        /// 景区音频
        /// </summary>
        [XmlElement("audio_url")]
        public string AudioUrl { get; set; }

        /// <summary>
        /// 头像图片
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 商业链接
        /// </summary>
        [XmlElement("buy_url")]
        public string BuyUrl { get; set; }

        /// <summary>
        /// 景点当前的舒适度等级
        /// </summary>
        [XmlElement("comfort_level")]
        public string ComfortLevel { get; set; }

        /// <summary>
        /// 中文描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 距离，单位米
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 景点的历史趣闻
        /// </summary>
        [XmlElement("historical_curiosities")]
        public string HistoricalCuriosities { get; set; }

        /// <summary>
        /// 景点图片
        /// </summary>
        [XmlArray("img_list")]
        [XmlArrayItem("string")]
        public List<string> ImgList { get; set; }

        /// <summary>
        /// 景点的一句话介绍
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 景点ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 两景点间推荐交通方式
        /// </summary>
        [XmlElement("line_type")]
        public string LineType { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 直线距离，单位米
        /// </summary>
        [XmlElement("meters")]
        public long Meters { get; set; }

        /// <summary>
        /// 拍照建议图片
        /// </summary>
        [XmlArray("photo_suggest_image_list")]
        [XmlArrayItem("string")]
        public List<string> PhotoSuggestImageList { get; set; }

        /// <summary>
        /// 拍照建议文案
        /// </summary>
        [XmlElement("photo_suggest_text")]
        public string PhotoSuggestText { get; set; }

        /// <summary>
        /// 位置类型
        /// </summary>
        [XmlElement("poi_type")]
        public string PoiType { get; set; }

        /// <summary>
        /// 当前位置到景点的推荐路线经纬度坐标列表
        /// </summary>
        [XmlArray("polyline")]
        [XmlArrayItem("string")]
        public List<string> Polyline { get; set; }

        /// <summary>
        /// 关联的商家
        /// </summary>
        [XmlArray("related_merchant_list")]
        [XmlArrayItem("string")]
        public List<string> RelatedMerchantList { get; set; }

        /// <summary>
        /// 关联的门票
        /// </summary>
        [XmlArray("related_ticket_list")]
        [XmlArrayItem("string")]
        public List<string> RelatedTicketList { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 路线预计长度，单位米
        /// </summary>
        [XmlElement("travel_distance")]
        public string TravelDistance { get; set; }

        /// <summary>
        /// 路线预计耗时，如10分钟，1时1分
        /// </summary>
        [XmlElement("travel_duration")]
        public string TravelDuration { get; set; }
    }
}
