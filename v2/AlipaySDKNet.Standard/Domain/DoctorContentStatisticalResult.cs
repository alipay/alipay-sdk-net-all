using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorContentStatisticalResult Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorContentStatisticalResult : AopObject
    {
        /// <summary>
        /// 累计用户观看文章数
        /// </summary>
        [XmlElement("article_pv_total")]
        public string ArticlePvTotal { get; set; }

        /// <summary>
        /// 累计发送图文公益文章数
        /// </summary>
        [XmlElement("article_total")]
        public string ArticleTotal { get; set; }

        /// <summary>
        /// 累计直播观看次数
        /// </summary>
        [XmlElement("live_pv_total")]
        public string LivePvTotal { get; set; }

        /// <summary>
        /// 累计直播次数
        /// </summary>
        [XmlElement("live_total")]
        public string LiveTotal { get; set; }

        /// <summary>
        /// 外部医生ID
        /// </summary>
        [XmlElement("merchant_doctor_id")]
        public string MerchantDoctorId { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [XmlElement("praise_count")]
        public string PraiseCount { get; set; }

        /// <summary>
        /// 累计用户观看视频数
        /// </summary>
        [XmlElement("video_pv_total")]
        public string VideoPvTotal { get; set; }

        /// <summary>
        /// 累计发送公益短视频或科普是视频数
        /// </summary>
        [XmlElement("video_total")]
        public string VideoTotal { get; set; }
    }
}
