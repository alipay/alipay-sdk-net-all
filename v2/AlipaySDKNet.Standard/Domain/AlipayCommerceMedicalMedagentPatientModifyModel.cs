using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentPatientModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentPatientModifyModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 就诊人出生日期
        /// </summary>
        [XmlElement("patient_birth")]
        public string PatientBirth { get; set; }

        /// <summary>
        /// 就诊人性别
        /// </summary>
        [XmlElement("patient_gender")]
        public string PatientGender { get; set; }

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
