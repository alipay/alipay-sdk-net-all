using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileDetectItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileDetectItemDTO : AopObject
    {
        /// <summary>
        /// 检测项结论
        /// </summary>
        [XmlElement("detect_item_conclusion")]
        public string DetectItemConclusion { get; set; }

        /// <summary>
        /// 检测项描述
        /// </summary>
        [XmlElement("detect_item_desc")]
        public string DetectItemDesc { get; set; }

        /// <summary>
        /// 检测步骤
        /// </summary>
        [XmlElement("detect_item_step")]
        public string DetectItemStep { get; set; }

        /// <summary>
        /// 检测项-子项目
        /// </summary>
        [XmlElement("detect_item_sub_type")]
        public string DetectItemSubType { get; set; }

        /// <summary>
        /// 证据项文本
        /// </summary>
        [XmlElement("evidence_text")]
        public string EvidenceText { get; set; }

        /// <summary>
        /// 检测项专家意见
        /// </summary>
        [XmlElement("expert_opinion")]
        public string ExpertOpinion { get; set; }
    }
}
