using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformInquiryOrderEvaluateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformInquiryOrderEvaluateInfo : AopObject
    {
        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("evaluate_content")]
        public string EvaluateContent { get; set; }

        /// <summary>
        /// 评价标签
        /// </summary>
        [XmlElement("evaluate_label")]
        public string EvaluateLabel { get; set; }

        /// <summary>
        /// 评价分数；例如99、89
        /// </summary>
        [XmlElement("evaluate_score")]
        public string EvaluateScore { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 评价是否可透出
        /// </summary>
        [XmlElement("open_status")]
        public bool OpenStatus { get; set; }
    }
}
