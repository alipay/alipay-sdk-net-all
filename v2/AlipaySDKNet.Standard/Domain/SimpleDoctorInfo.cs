using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleDoctorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleDoctorInfo : AopObject
    {
        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }
    }
}
