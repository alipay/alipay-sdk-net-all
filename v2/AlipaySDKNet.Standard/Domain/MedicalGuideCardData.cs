using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalGuideCardData Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalGuideCardData : AopObject
    {
        /// <summary>
        /// 是否为手动输入
        /// </summary>
        [XmlElement("manual_input")]
        public bool ManualInput { get; set; }

        /// <summary>
        /// 选项
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("string")]
        public List<string> Options { get; set; }

        /// <summary>
        /// 选项类型
        /// </summary>
        [XmlElement("options_choice_type")]
        public string OptionsChoiceType { get; set; }

        /// <summary>
        /// 对话是否刷新
        /// </summary>
        [XmlElement("refresh")]
        public bool Refresh { get; set; }

        /// <summary>
        /// 特殊选项
        /// </summary>
        [XmlArray("special_options")]
        [XmlArrayItem("string")]
        public List<string> SpecialOptions { get; set; }

        /// <summary>
        /// 症状部位信息
        /// </summary>
        [XmlArray("symptom_part_infos")]
        [XmlArrayItem("symptom_part_info")]
        public List<SymptomPartInfo> SymptomPartInfos { get; set; }

        /// <summary>
        /// 医疗导诊结果标签
        /// </summary>
        [XmlArray("tabs")]
        [XmlArrayItem("medical_guide_tab")]
        public List<MedicalGuideTab> Tabs { get; set; }
    }
}
