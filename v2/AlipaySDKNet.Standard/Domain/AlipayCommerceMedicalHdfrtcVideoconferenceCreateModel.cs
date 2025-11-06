using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideoconferenceCreateModel : AopObject
    {
        /// <summary>
        /// 患者ID
        /// </summary>
        [XmlElement("patient_id")]
        public long PatientId { get; set; }

        /// <summary>
        /// 时间格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("scheduled_end_time")]
        public string ScheduledEndTime { get; set; }

        /// <summary>
        /// 时间格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("scheduled_start_time")]
        public string ScheduledStartTime { get; set; }

        /// <summary>
        /// 好大夫侧获取外部来源ID，如执行单ID
        /// </summary>
        [XmlElement("source_id")]
        public long SourceId { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 从好大夫侧获取医生空间
        /// </summary>
        [XmlElement("space_id")]
        public long SpaceId { get; set; }

        /// <summary>
        /// 好大夫侧用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
