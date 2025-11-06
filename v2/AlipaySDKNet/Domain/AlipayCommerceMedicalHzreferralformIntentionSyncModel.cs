using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformIntentionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHzreferralformIntentionSyncModel : AopObject
    {
        /// <summary>
        /// 备注，解释医生的审核结果，转诊失败时必须传
        /// </summary>
        [XmlElement("doctor_remark")]
        public string DoctorRemark { get; set; }

        /// <summary>
        /// 医生处理转诊的时间
        /// </summary>
        [XmlElement("process_time")]
        public string ProcessTime { get; set; }

        /// <summary>
        /// 转诊单单号，为转诊单表的主键，自动生成，提供给外部使用
        /// </summary>
        [XmlElement("referral_form_id")]
        public string ReferralFormId { get; set; }

        /// <summary>
        /// 转诊单状态：1-已转诊、0-拒绝
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 就诊科室，提供给用户查看就诊成功后的就诊信息
        /// </summary>
        [XmlElement("visit_department")]
        public string VisitDepartment { get; set; }

        /// <summary>
        /// 就诊医生，提供给用户查看就诊成功后的就诊信息
        /// </summary>
        [XmlElement("visit_doctor")]
        public string VisitDoctor { get; set; }

        /// <summary>
        /// 就诊医院，提供给用户查看就诊成功后的就诊信息
        /// </summary>
        [XmlElement("visit_hospital")]
        public string VisitHospital { get; set; }

        /// <summary>
        /// 医生选择的就诊时间
        /// </summary>
        [XmlElement("visit_time")]
        public string VisitTime { get; set; }
    }
}
