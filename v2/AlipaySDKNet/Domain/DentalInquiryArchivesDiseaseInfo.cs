using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DentalInquiryArchivesDiseaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DentalInquiryArchivesDiseaseInfo : AopObject
    {
        /// <summary>
        /// 用于描述病症的治疗阶段
        /// </summary>
        [XmlElement("inquiry_status")]
        public string InquiryStatus { get; set; }

        /// <summary>
        /// 1：主诉 0：非主诉
        /// </summary>
        [XmlElement("main_demands")]
        public long MainDemands { get; set; }

        /// <summary>
        /// 商家提供的病症ID
        /// </summary>
        [XmlElement("out_disease_id")]
        public string OutDiseaseId { get; set; }

        /// <summary>
        /// 用于描述病症的基础症状
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 用于描述症状的严重程度
        /// </summary>
        [XmlElement("question_level")]
        public DentalInquiryArchivesDiseaseLevelInfo QuestionLevel { get; set; }

        /// <summary>
        /// 用于记录牙位问题位置：全口、左上1~8、左下1~8...
        /// </summary>
        [XmlElement("question_position")]
        public string QuestionPosition { get; set; }

        /// <summary>
        /// 描述病症存在的风险
        /// </summary>
        [XmlElement("question_risk")]
        public string QuestionRisk { get; set; }

        /// <summary>
        /// 医生针对病症的建议列表
        /// </summary>
        [XmlArray("question_suggestion")]
        [XmlArrayItem("string")]
        public List<string> QuestionSuggestion { get; set; }

        /// <summary>
        /// 记录病症的读取状态，用于C端病症卡片呈现样式
        /// </summary>
        [XmlElement("read_status")]
        public string ReadStatus { get; set; }
    }
}
