using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentDoctoragentstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentDoctoragentstatusQueryModel : AopObject
    {
        /// <summary>
        /// 好大夫端医生的id
        /// </summary>
        [XmlElement("hdf_doctor_id")]
        public string HdfDoctorId { get; set; }
    }
}
