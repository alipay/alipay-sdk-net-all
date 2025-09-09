using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduAssessmentScore Data Structure.
    /// </summary>
    [Serializable]
    public class EduAssessmentScore : AopObject
    {
        /// <summary>
        /// 评分维度
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
