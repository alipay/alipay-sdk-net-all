using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendDoctorDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendDoctorDetail : AopObject
    {
        /// <summary>
        /// 行业医生id
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
