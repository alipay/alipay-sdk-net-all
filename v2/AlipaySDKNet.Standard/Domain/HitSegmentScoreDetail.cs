using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HitSegmentScoreDetail Data Structure.
    /// </summary>
    [Serializable]
    public class HitSegmentScoreDetail : AopObject
    {
        /// <summary>
        /// 全文相似度评分（以小数形式表示，取值范围为0到1）
        /// </summary>
        [XmlElement("full_text_score")]
        public string FullTextScore { get; set; }

        /// <summary>
        /// 整体评分（以小数形式表示，取值范围为0到1）
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 向量相似度评分（以小数形式表示，取值范围为0到1）
        /// </summary>
        [XmlElement("vector_score")]
        public string VectorScore { get; set; }
    }
}
