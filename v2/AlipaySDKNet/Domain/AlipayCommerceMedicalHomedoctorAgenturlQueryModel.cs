using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorAgenturlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHomedoctorAgenturlQueryModel : AopObject
    {
        /// <summary>
        /// 医生的身份信息
        /// </summary>
        [XmlElement("doctor_cert_no")]
        public string DoctorCertNo { get; set; }
    }
}
