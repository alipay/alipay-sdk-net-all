using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFIllnessHistory Data Structure.
    /// </summary>
    [Serializable]
    public class HDFIllnessHistory : AopObject
    {
        /// <summary>
        /// 既往病史描述
        /// </summary>
        [XmlElement("medical_history_desc")]
        public string MedicalHistoryDesc { get; set; }

        /// <summary>
        /// 1（手术）/2（重大疾病）/8（放化疗）/9 （甲状腺或肾上腺疾病史）
        /// </summary>
        [XmlElement("medical_history_type")]
        public string MedicalHistoryType { get; set; }
    }
}
