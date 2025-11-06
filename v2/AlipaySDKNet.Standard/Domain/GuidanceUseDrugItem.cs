using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuidanceUseDrugItem Data Structure.
    /// </summary>
    [Serializable]
    public class GuidanceUseDrugItem : AopObject
    {
        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("drug_name")]
        public string DrugName { get; set; }

        /// <summary>
        /// 药品数量
        /// </summary>
        [XmlElement("drug_num")]
        public string DrugNum { get; set; }

        /// <summary>
        /// 药品规格，常见单位有mg、g、IU、毫克（mg）、毫升（ml），单位拼接成字符串使用
        /// </summary>
        [XmlElement("drug_specifications")]
        public string DrugSpecifications { get; set; }

        /// <summary>
        /// 用药医嘱
        /// </summary>
        [XmlElement("notice_info")]
        public string NoticeInfo { get; set; }

        /// <summary>
        /// 超说明书用药说明
        /// </summary>
        [XmlElement("over_instruction_str")]
        public string OverInstructionStr { get; set; }

        /// <summary>
        /// 用法用量，如mg、ml、次/天等，单位拼接后使用
        /// </summary>
        [XmlElement("usage")]
        public string Usage { get; set; }
    }
}
