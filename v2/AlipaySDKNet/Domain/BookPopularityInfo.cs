using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookPopularityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BookPopularityInfo : AopObject
    {
        /// <summary>
        /// 书籍购买量
        /// </summary>
        [XmlElement("buy_count")]
        public long BuyCount { get; set; }

        /// <summary>
        /// 书籍收藏量
        /// </summary>
        [XmlElement("collect_count")]
        public long CollectCount { get; set; }

        /// <summary>
        /// 书籍阅读量
        /// </summary>
        [XmlElement("read_count")]
        public long ReadCount { get; set; }

        /// <summary>
        /// 书籍评分（10分制，保留一位小数）
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 书籍分享量
        /// </summary>
        [XmlElement("share_count")]
        public long ShareCount { get; set; }
    }
}
