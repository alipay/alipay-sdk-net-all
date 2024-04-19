using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalGuideCardDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalGuideCardDTO : AopObject
    {
        /// <summary>
        /// 医疗导诊结果卡片数据
        /// </summary>
        [XmlElement("card_data")]
        public MedicalGuideCardData CardData { get; set; }

        /// <summary>
        /// 医疗导诊结果卡片类型
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
