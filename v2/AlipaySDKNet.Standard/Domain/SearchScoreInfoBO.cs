using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchScoreInfoBO Data Structure.
    /// </summary>
    [Serializable]
    public class SearchScoreInfoBO : AopObject
    {
        /// <summary>
        /// 权威分，十分制
        /// </summary>
        [XmlElement("authority_score")]
        public string AuthorityScore { get; set; }

        /// <summary>
        /// 质量分，十分制
        /// </summary>
        [XmlElement("quality_score")]
        public string QualityScore { get; set; }

        /// <summary>
        /// 相关性分，十分制
        /// </summary>
        [XmlElement("relevance_score")]
        public string RelevanceScore { get; set; }

        /// <summary>
        /// 时效分，十分制
        /// </summary>
        [XmlElement("timeliness_score")]
        public string TimelinessScore { get; set; }
    }
}
