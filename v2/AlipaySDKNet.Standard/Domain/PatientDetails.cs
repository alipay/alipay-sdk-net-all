using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PatientDetails Data Structure.
    /// </summary>
    [Serializable]
    public class PatientDetails : AopObject
    {
        /// <summary>
        /// 0: 否 1:是
        /// </summary>
        [XmlElement("has_enter_room")]
        public long HasEnterRoom { get; set; }

        /// <summary>
        /// 好大夫侧患者ID
        /// </summary>
        [XmlElement("patient_id")]
        public long PatientId { get; set; }

        /// <summary>
        /// RTC侧用户ID
        /// </summary>
        [XmlElement("rtc_user_id")]
        public string RtcUserId { get; set; }

        /// <summary>
        /// 好大夫侧用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
