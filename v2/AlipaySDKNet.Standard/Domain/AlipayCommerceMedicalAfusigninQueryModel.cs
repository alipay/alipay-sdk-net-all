using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAfusigninQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAfusigninQueryModel : AopObject
    {
        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }
    }
}
