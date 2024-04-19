using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MovieList Data Structure.
    /// </summary>
    [Serializable]
    public class MovieList : AopObject
    {
        /// <summary>
        /// 演员阵容
        /// </summary>
        [XmlElement("cast")]
        public string Cast { get; set; }

        /// <summary>
        /// 电影制式
        /// </summary>
        [XmlElement("copy_types")]
        public string CopyTypes { get; set; }

        /// <summary>
        /// 海报
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 导演
        /// </summary>
        [XmlElement("director")]
        public string Director { get; set; }

        /// <summary>
        /// 电影时长
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 电影编码
        /// </summary>
        [XmlElement("film_code")]
        public string FilmCode { get; set; }

        /// <summary>
        /// 电影名称
        /// </summary>
        [XmlElement("film_name")]
        public string FilmName { get; set; }

        /// <summary>
        /// 影片 id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否为预售
        /// </summary>
        [XmlElement("is_booking")]
        public string IsBooking { get; set; }

        /// <summary>
        /// 电影语言
        /// </summary>
        [XmlElement("language")]
        public string Language { get; set; }

        /// <summary>
        /// 排期数量
        /// </summary>
        [XmlElement("plan_count")]
        public long PlanCount { get; set; }

        /// <summary>
        /// 上映日期
        /// </summary>
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 电影简介
        /// </summary>
        [XmlElement("simple_word")]
        public string SimpleWord { get; set; }

        /// <summary>
        /// 电影类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
