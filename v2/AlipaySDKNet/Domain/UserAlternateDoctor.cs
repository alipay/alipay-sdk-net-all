using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserAlternateDoctor Data Structure.
    /// </summary>
    [Serializable]
    public class UserAlternateDoctor : AopObject
    {
        /// <summary>
        /// 医生内部id
        /// </summary>
        [XmlElement("doctor_inner_id")]
        public string DoctorInnerId { get; set; }

        /// <summary>
        /// 好大夫医生id
        /// </summary>
        [XmlElement("hdf_doctor_id")]
        public string HdfDoctorId { get; set; }
    }
}
