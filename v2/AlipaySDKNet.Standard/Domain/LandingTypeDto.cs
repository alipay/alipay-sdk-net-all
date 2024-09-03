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
        /// 商品落地页id，同一个商品的落地页id唯一。
        /// </summary>
        [XmlElement("landing_id")]
        public string LandingId { get; set; }

        /// <summary>
        /// 落地页名称，同一个商品的落地页名称唯一。
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
        /// 图文落地页中的图片地址，landing_type值为2的时候必填，至少一张图片地址
        /// </summary>
        [XmlArray("pic_info_list")]
        [XmlArrayItem("string")]
        public List<string> PicInfoList { get; set; }

        /// <summary>
        /// 商品视频信息
        /// </summary>
        [XmlArray("product_videos")]
        [XmlArrayItem("video_info")]
        public List<VideoInfo> ProductVideos { get; set; }
    }
}
