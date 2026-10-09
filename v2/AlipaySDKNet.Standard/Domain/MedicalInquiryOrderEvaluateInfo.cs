using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalInquiryOrderEvaluateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalInquiryOrderEvaluateInfo : AopObject
    {
        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("evaluate_content")]
        public string EvaluateContent { get; set; }

        /// <summary>
        /// 标签内容，如“回答很及时”，“医术高明”等，用分隔符隔开，后续做差异化展示 文本内容，最多不超过500字
        /// </summary>
        [XmlElement("evaluate_label")]
        public string EvaluateLabel { get; set; }

        /// <summary>
        /// 规则标准：五星制，一位小数
        /// </summary>
        [XmlElement("evaluate_score")]
        public string EvaluateScore { get; set; }

        /// <summary>
        /// 格式：yyyy-mm-dd  hh:mm:ss
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 是/否
        /// </summary>
        [XmlElement("open_status")]
        public bool OpenStatus { get; set; }
    }
}
