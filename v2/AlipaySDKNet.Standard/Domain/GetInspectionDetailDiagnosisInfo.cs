using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetInspectionDetailDiagnosisInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GetInspectionDetailDiagnosisInfo : AopObject
    {
        /// <summary>
        /// ICD诊断编码
        /// </summary>
        [XmlElement("diacrisis_icd_code")]
        public string DiacrisisIcdCode { get; set; }

        /// <summary>
        /// 诊断信息
        /// </summary>
        [XmlElement("diagnosis")]
        public string Diagnosis { get; set; }
    }
}
