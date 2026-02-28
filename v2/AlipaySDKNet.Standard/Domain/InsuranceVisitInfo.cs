using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuranceVisitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuranceVisitInfo : AopObject
    {
        /// <summary>
        /// 医院名
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 就诊类型
        /// </summary>
        [XmlElement("medical_type")]
        public string MedicalType { get; set; }

        /// <summary>
        /// 就诊日期 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("visit_date")]
        public string VisitDate { get; set; }
    }
}
