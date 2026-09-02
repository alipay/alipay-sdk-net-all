using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHmActivityRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHmActivityRecord : AopObject
    {
        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("activity_end_date")]
        public string ActivityEndDate { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动开启时间
        /// </summary>
        [XmlElement("activity_start_date")]
        public string ActivityStartDate { get; set; }

        /// <summary>
        /// 活动副标题
        /// </summary>
        [XmlElement("activity_sub_title")]
        public string ActivitySubTitle { get; set; }

        /// <summary>
        /// 活动主标题
        /// </summary>
        [XmlElement("activity_title")]
        public string ActivityTitle { get; set; }

        /// <summary>
        /// 报名时间
        /// </summary>
        [XmlElement("registration_date")]
        public string RegistrationDate { get; set; }
    }
}
