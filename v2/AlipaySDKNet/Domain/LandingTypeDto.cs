using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LandingTypeDto Data Structure.
    /// </summary>
    [Serializable]
    public class LandingTypeDto : AopObject
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("landing_act")]
        [XmlArrayItem("landing_act_dto")]
        public List<LandingActDto> LandingAct { get; set; }

        /// <summary>
        /// 商品落地页id
        /// </summary>
        [XmlElement("landing_id")]
        public string LandingId { get; set; }

        /// <summary>
        /// 落地页名称
        /// </summary>
        [XmlElement("landing_name")]
        public string LandingName { get; set; }

        /// <summary>
        /// 视频落地页
        /// </summary>
        [XmlElement("landing_type")]
        public string LandingType { get; set; }

        /// <summary>
        /// 商品落地页url
        /// </summary>
        [XmlElement("landing_url")]
        public string LandingUrl { get; set; }

        /// <summary>
        /// 商品视频信息
        /// </summary>
        [XmlArray("product_videos")]
        [XmlArrayItem("video_info")]
        public List<VideoInfo> ProductVideos { get; set; }
    }
}
