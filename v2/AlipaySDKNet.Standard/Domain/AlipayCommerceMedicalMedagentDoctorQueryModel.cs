using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentDoctorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentDoctorQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁侧医生id，线下提供映射即可。假设一个人绑定了3个医生则需要调用三次
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }
    }
}
