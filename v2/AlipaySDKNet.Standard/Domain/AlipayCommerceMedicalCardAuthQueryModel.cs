using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardAuthQueryModel : AopObject
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("ins_code")]
        public string InsCode { get; set; }

        /// <summary>
        /// 就诊人有效身份证件号码
        /// </summary>
        [XmlElement("patient_cert_no")]
        public string PatientCertNo { get; set; }

        /// <summary>
        /// 当前就诊人的有效身份证件类型编码
        /// </summary>
        [XmlElement("patient_cert_type")]
        public string PatientCertType { get; set; }

        /// <summary>
        /// 就诊人与当前登录用户的关系
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }
    }
}
