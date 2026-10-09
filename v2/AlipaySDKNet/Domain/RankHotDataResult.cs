using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RankHotDataResult Data Structure.
    /// </summary>
    [Serializable]
    public class RankHotDataResult : AopObject
    {
        /// <summary>
        /// 热点榜id
        /// </summary>
        [XmlElement("hot_id")]
        public string HotId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [XmlElement("index")]
        public string Index { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 发布时间戳
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 车系id
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 内容id列表
        /// </summary>
        [XmlArray("unique_id")]
        [XmlArrayItem("string")]
        public List<string> UniqueId { get; set; }
    }
}
