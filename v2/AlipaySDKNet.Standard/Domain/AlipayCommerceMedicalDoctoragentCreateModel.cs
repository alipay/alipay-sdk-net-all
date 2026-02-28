using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoragentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctoragentCreateModel : AopObject
    {
        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }
    }
}
