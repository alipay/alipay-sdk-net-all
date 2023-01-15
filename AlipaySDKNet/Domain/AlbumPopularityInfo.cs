using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlbumPopularityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlbumPopularityInfo : AopObject
    {
        /// <summary>
        /// 专辑购买量
        /// </summary>
        [XmlElement("buy_count")]
        public long BuyCount { get; set; }

        /// <summary>
        /// 专辑收藏量
        /// </summary>
        [XmlElement("collect_count")]
        public long CollectCount { get; set; }

        /// <summary>
        /// 专辑播放量
        /// </summary>
        [XmlElement("play_count")]
        public long PlayCount { get; set; }

        /// <summary>
        /// 专辑评分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 专辑分享量
        /// </summary>
        [XmlElement("share_count")]
        public long ShareCount { get; set; }
    }
}
