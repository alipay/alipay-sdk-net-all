using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHdfaitransferMedicationguidanceGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHdfaitransferMedicationguidanceGenerateModel : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 过敏史
        /// </summary>
        [XmlElement("allergic_history")]
        public string AllergicHistory { get; set; }

        /// <summary>
        /// 病情描述
        /// </summary>
        [XmlElement("condition_description")]
        public string ConditionDescription { get; set; }

        /// <summary>
        /// 处方诊断
        /// </summary>
        [XmlElement("diagnosis")]
        public string Diagnosis { get; set; }

        /// <summary>
        /// 是否怀孕
        /// </summary>
        [XmlElement("gestation_str")]
        public string GestationStr { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("guidance_use_drug_list")]
        [XmlArrayItem("guidance_use_drug_item")]
        public List<GuidanceUseDrugItem> GuidanceUseDrugList { get; set; }

        /// <summary>
        /// 同时使用
        /// </summary>
        [XmlElement("need_same_time")]
        public string NeedSameTime { get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [XmlElement("precautions")]
        public string Precautions { get; set; }

        /// <summary>
        /// 服药期间复查信息
        /// </summary>
        [XmlElement("recheck_str")]
        public string RecheckStr { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 服用期间特殊叮嘱
        /// </summary>
        [XmlElement("use_drug_warn_str")]
        public string UseDrugWarnStr { get; set; }

        /// <summary>
        /// 体重，单位固定是kg，作为字符串使用
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
