using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WesternMedicationInformation Data Structure.
    /// </summary>
    [Serializable]
    public class WesternMedicationInformation : AopObject
    {
        /// <summary>
        /// 药品用量  eg：每次0.5g（2粒），每日3次
        /// </summary>
        [XmlElement("dosage")]
        public string Dosage { get; set; }

        /// <summary>
        /// 药品名称 eg： 阿司匹林
        /// </summary>
        [XmlElement("medical_name")]
        public string MedicalName { get; set; }

        /// <summary>
        /// 备注 eg： 饭后服用，连用7天
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 规格eg： 0.25g *24粒
        /// </summary>
        [XmlElement("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// 用法  eg：20.00（g）
        /// </summary>
        [XmlElement("usage")]
        public string Usage { get; set; }
    }
}
