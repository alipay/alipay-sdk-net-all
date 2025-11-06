using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformDetailGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHzreferralformDetailGetModel : AopObject
    {
        /// <summary>
        /// 医生的身份信息，用于判断医生权限，是否能够获取转诊单列表
        /// </summary>
        [XmlElement("doctor_cert_no")]
        public string DoctorCertNo { get; set; }

        /// <summary>
        /// 转诊单单号，为转诊单表的主键，自动生成，提供给外部使用
        /// </summary>
        [XmlElement("referral_form_id")]
        public string ReferralFormId { get; set; }
    }
}
