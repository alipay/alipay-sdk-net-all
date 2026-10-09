using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedregisterSourcesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedregisterSourcesQueryModel : AopObject
    {
        /// <summary>
        /// 上午
        /// </summary>
        [XmlElement("am_pm")]
        public string AmPm { get; set; }

        /// <summary>
        /// 机构下的分院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构id对应的机构名称
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 用户id类型
        /// </summary>
        [XmlElement("out_user_type")]
        public string OutUserType { get; set; }

        /// <summary>
        /// 排班id
        /// </summary>
        [XmlElement("schedule_id")]
        public string ScheduleId { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 2024年11月15日
        /// </summary>
        [XmlElement("treat_date")]
        public string TreatDate { get; set; }
    }
}
