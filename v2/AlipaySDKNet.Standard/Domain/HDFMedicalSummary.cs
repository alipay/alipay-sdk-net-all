using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFMedicalSummary Data Structure.
    /// </summary>
    [Serializable]
    public class HDFMedicalSummary : AopObject
    {
        /// <summary>
        /// diacrisis初步诊断
        /// </summary>
        [XmlElement("diacrisis")]
        public string Diacrisis { get; set; }

        /// <summary>
        /// 处置
        /// </summary>
        [XmlElement("idea")]
        public string Idea { get; set; }

        /// <summary>
        /// 病历概要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }
    }
}
