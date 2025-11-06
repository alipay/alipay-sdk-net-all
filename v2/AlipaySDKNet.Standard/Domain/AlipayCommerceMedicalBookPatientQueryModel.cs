using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBookPatientQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBookPatientQueryModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询就诊人的唯一标识
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
