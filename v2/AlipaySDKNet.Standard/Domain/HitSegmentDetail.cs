using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HitSegmentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class HitSegmentDetail : AopObject
    {
        /// <summary>
        /// 分片内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 分片元数据
        /// </summary>
        [XmlElement("meta")]
        public HitSegmentMetaDetail Meta { get; set; }

        /// <summary>
        /// 分片评分
        /// </summary>
        [XmlElement("score")]
        public HitSegmentScoreDetail Score { get; set; }
    }
}
