using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorDetails Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorDetails : AopObject
    {
        /// <summary>
        /// 是否进入诊室
        /// </summary>
        [XmlElement("has_enter_room")]
        public long HasEnterRoom { get; set; }

        /// <summary>
        /// RTC侧用户ID
        /// </summary>
        [XmlElement("rtc_user_id")]
        public string RtcUserId { get; set; }

        /// <summary>
        /// 医生空间ID
        /// </summary>
        [XmlElement("space_id")]
        public long SpaceId { get; set; }
    }
}
